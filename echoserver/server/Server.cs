
using System.Net;
using System.Net.Sockets;

int size;
byte[] buffer;
Socket accept_socket, listen_socket;

buffer = new byte[4096];

Console.WriteLine("Hello, this is the server side!\n");
IPEndPoint endPoint_Listen = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11001);
listen_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);

listen_socket.Bind(endPoint_Listen);
listen_socket.Listen(1000);

accept_socket = listen_socket.Accept();
size = accept_socket.Receive(buffer);

accept_socket.Send(buffer, size, SocketFlags.None);

accept_socket.Close();
listen_socket.Close();