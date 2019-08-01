using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public class Client
    {
        private string _ConnectionName = "";
        public string ConnectionName { get { return _ConnectionName; } set { _ConnectionName = value; } }

        TcpClient clientSocket = new TcpClient();
         public readonly NetworkStream serverStream;
        public void Connect(string server, int port)
        {
            if (!clientSocket.Connected)
            {
                try
                {
                    clientSocket.Connect(server, port);
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

                }
                catch (Exception)
                {
                    return "ERROR " + returndata;
                }

                return "" + returndata;
            }
        }
    }
}
