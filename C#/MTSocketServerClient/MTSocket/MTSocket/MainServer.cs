using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace MTSocket
{
    class MainServer
    {
        private static Thread masThread;
        private static MAS mas;

        public static void StartServer(int ListenPort, IPAddress ListenIP)
        {
            DebugConsole.Debugger.WriteConsole("Server Başlatılıyor", "Thread", "");
            mas = new MAS(ListenPort, ListenIP);
            masThread = new Thread(new ThreadStart(mas.StartListener));
            masThread.Start();
        }
        public static void StopServer()
        {
            if (masThread != null)
                if (masThread.IsAlive)
                {
                    mas.StopListener();
                    masThread.Abort();
                }
        }
        private class MAS
        {
            public MAS(int ListenPort, IPAddress ListenIP)
            {
                this._ListenPort = ListenPort;
                this._ListenIP = ListenIP;
                DebugConsole.Debugger.WriteConsole(ListenIP.ToString() + " : " + ListenPort.ToString(), "Thread", "MAS");
            }

            private int _ListenPort = 8000;
            private IPAddress _ListenIP = IPAddress.Any;

            TcpListener serverSocket;
            TcpClient clientSocket;
            public void StopListener()
            {
                if (clientSocket != null)
                    clientSocket.Close();
                serverSocket.Stop();
            }

            public void StartListener()
            {
                bool done = false;
                serverSocket = new TcpListener(_ListenIP, _ListenPort);
                clientSocket = default(TcpClient);
                int counter = 0;
                counter = 0;

                serverSocket.Start();
                try
                {
                    while (!done)
                    {
                        counter += 1;
                        DebugConsole.Debugger.WriteConsole("Yeni Bağlantı için Bekleniyor", "Listener", "MAS");
                        clientSocket = serverSocket.AcceptTcpClient();
                        handleClinet client = new handleClinet();
                        client.startClient(clientSocket, Convert.ToString(counter));
                    }
                }
                catch (ThreadAbortException)
                {
                    done = true;
                    DebugConsole.Debugger.WriteConsole("Sonlandırma Talebi", "Listener", "MAS");
                }
                catch (Exception e)
                {
                    DebugConsole.Debugger.WriteConsole("Error: " + e.Message, "Listener", "MAS");
                }
                finally
                {
                    if (clientSocket != null)
                        clientSocket.Close();
                    serverSocket.Stop();
                }
            }
            //Class to handle each client request separatly
            public class handleClinet
            {
                TcpClient clientSocket;
                //string clNo;
                public void startClient(TcpClient inClientSocket, string clineNo)
                {
                    DebugConsole.Debugger.WriteConsole("Client :" + clineNo, "handleClient", "MAS");
                    this.clientSocket = inClientSocket;
                    //this.clNo = clineNo;
                    Thread ctThread = new Thread(doChat);
                    ctThread.Start();
                }

                private void doChat()
                {
                    byte[] bytesFrom = new byte[10 * 1024 + 1];
                    string dataFromClient = null;
                    Byte[] sendBytes = null;
                    string serverResponse = null;

                    while ((true))
                    {

                        try
                        {
                            DebugConsole.Debugger.WriteConsole("Data Bekleniyor","doChat", "MAS");
                            NetworkStream networkStream = clientSocket.GetStream();

                            bytesFrom = new byte[1000 * 1024 + 1];
                            networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                            dataFromClient = "";
                            dataFromClient = System.Text.Encoding.UTF8.GetString(bytesFrom);
                            DebugConsole.Debugger.WriteConsole(dataFromClient, "doChat", "Clientten gelen data");

                            dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("\0"));

                            /////////////////////////////////////////////////////////////////////////////
                            /////////////////////////////////////////////////////////////////////////////
                            /////////////////Gelen veri işlenip burada cevap yollanılıyor////////////////
                            /////////////////////////////////////////////////////////////////////////////
                            
                            serverResponse = "Server Response :" + dataFromClient;
                            
                            DebugConsole.Debugger.WriteConsole(serverResponse, "doChat", "Server cevabı");
                            sendBytes = null;
                            sendBytes = Encoding.UTF8.GetBytes(serverResponse);
                            networkStream.Write(sendBytes, 0, sendBytes.Length);
                            networkStream.Flush();
                        }
                        catch (Exception ex)
                        {
                            DebugConsole.Debugger.WriteConsole("Error: " + ex.Message, "doChat", "MAS");
                            break;
                        }
                    }
                }
            }


        }
    }
}