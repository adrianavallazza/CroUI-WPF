using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace CroUI.TcpIp
{
    public class Client
    {
        private byte[] rcvData = new byte[256];
        private byte[] sendData = new byte[128];
        IPEndPoint ipEndPoint;
        Socket server;

        public Client()
        {
            ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.2"), 54000);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void connect()
        {
           try
            {
                server.Connect(ipEndPoint);
            } catch(SocketException socketEx)
            {
                // ToDo
            }
        }

        public void send(byte[] command)
        {
            try
            {
                server.Send(command);
            } catch(SocketException socketEx)
            {
                // ToDo
            } catch(Exception ex)
            {
                // ToDo
            }
        }
    }
}
