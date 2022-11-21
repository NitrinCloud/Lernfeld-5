using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{
    public class Server
    {

        public static void Main()
        {
            new Server("127.0.0.1", 25565).Start();
        }

        private readonly string _hostname;
        private readonly int _port;

        public Server(string hostname, int port)
        {
            _hostname = hostname ?? throw new ArgumentNullException(nameof(hostname));
            _port = port;
        }

        public void Start()
        {
            var listener = new TcpListener(new IPEndPoint(IPAddress.Parse(_hostname), _port));
            listener.Start();

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Parse(_hostname), _port));
            socket.Listen(100);

            while (true)
            {
                var client = socket.Accept();
                    
                var thread = new Thread(() => listenClient(client));
                thread.Start();
            }
        }

        private void listenClient(Socket client)
        {
            while (client.Connected)
            {
                
            }
            client.Close();
        }
    }
}