using System;
using System.Net;
using System.Net.Sockets;

namespace ChatApp
{
    public class Connection
    {
        private string _ip;
        private int _port;
        public Socket ClientSocket;

        public void GetIP()
        {
            _ip = "127.0.0.1";
        }
        public void GetPort()
        {
            _port = 13000;
        }
        public Socket Connect()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(_ip), _port);
            socket.Bind(ep);
            return socket;
        }

        public void StartListening(Socket chatSocket)
        {
            chatSocket.Listen(1);
            Console.WriteLine("__________Ready____________");
            ClientSocket = default(Socket);
            ClientSocket = chatSocket.Accept();
            Console.WriteLine("---------Connected---------");
        }
    }
}

