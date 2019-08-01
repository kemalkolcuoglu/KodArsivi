using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace MTSocketClient
{
    class MainClient
    {
        private string _ConnectionName = "";
        public string ConnectionName { get { return _ConnectionName; } set { _ConnectionName = value; } }

        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream;
        public void Connect(string server, int port)
        {
            if (!clientSocket.Connected)
            {
                try
                {
                    clientSocket.Connect(server, port);
                    //Public.Debugger.WriteConsole(
                    //    "Servera Bağlandı: " +
                    //    Public.Settings.ServerIP.ToString() + ":" +
                    //    Public.Settings.ServerPort, "Client", "MAC");
                }
                catch (Exception)
                {

                }
            }
        }
        public void DisConnect()
        {
            if (clientSocket.Connected)
            {
                clientSocket.Close();
                //Public.Debugger.WriteConsole("Server Bağlantısı Kapandı", "Client", "MAC");
            }
        }

        public bool CheckState()
        {
            return clientSocket.Connected;
        }

        public string Send(string Data)
        {
            string returndata = "";
            if (!clientSocket.Connected)
            {
                //Connect();
                //return Send(Data);
                return "Not Connected";
            }
            else
            {
                try
                {
                    NetworkStream serverStream = clientSocket.GetStream();
                    byte[] outStream = System.Text.Encoding.UTF8.GetBytes(Data);
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();

                    byte[] inStream = new byte[1000 * 1024 + 1];
                    serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                    returndata = System.Text.Encoding.UTF8.GetString(inStream);
                    returndata = returndata.Substring(0, returndata.IndexOf("\0"));

                    //Public.Debugger.WriteConsole(returndata, "Client", "MAC");

                    //Local_Chat.Client.Data.Data.SetData(returndata);
                }
                catch (Exception)
                {
                    return "ERROR " + returndata;
                }

                return "SENDED " + returndata;
            }
        }
    }
}