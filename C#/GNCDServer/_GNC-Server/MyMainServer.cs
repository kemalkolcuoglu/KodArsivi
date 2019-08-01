using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace MTSocket
{
    public class MyMainServer
    {
        private static Thread masThread;
        private static MAS mas;

        public static void StartServer(int ListenPort, IPAddress ListenIP)
        {

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

            }

            private int _ListenPort = 5241;
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

                        clientSocket = serverSocket.AcceptTcpClient();
                        handleClinet client = new handleClinet();
                        client.startClient(clientSocket, Convert.ToString(counter));
                    }
                }
                catch (ThreadAbortException)
                {
                    done = true;
                }
                catch (Exception e)
                {

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

                            NetworkStream networkStream = clientSocket.GetStream();

                            bytesFrom = new byte[1000 * 1024 + 1];
                            networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                            dataFromClient = "";
                            dataFromClient = System.Text.Encoding.UTF8.GetString(bytesFrom);


                            dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("\0"));

                            /////////////////////////////////////////////////////////////////////////////
                            /////////////////////////////////////////////////////////////////////////////
                            /////////////////Gelen veri işlenip burada cevap yollanılıyor////////////////
                            /////////////////////////////////////////////////////////////////////////////

                            serverResponse = dataFromClient;


                            sendBytes = null;
                            sendBytes = Encoding.UTF8.GetBytes(serverResponse);
                            networkStream.Write(sendBytes, 0, sendBytes.Length);
                            networkStream.Flush();
                        }
                        catch (Exception)
                        {

                            break;
                        }
                    }
                }
            }


        }
    }
}