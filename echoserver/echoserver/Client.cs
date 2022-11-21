using System.Net.Sockets;
using System.Text;

Console.WriteLine("Hello, this is the client side!\n");

// Create socket comunication
Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

// Atempt to conect into the socket
try
{
    socket.Connect("127.0.0.1", 11001);
    byte[] buffer_envio = Encoding.Default.GetBytes("Winter is Coming");
    socket.Send(buffer_envio);
    byte[] buffer_receive = new byte[1024];
    int receive_size = socket.Receive(buffer_envio);
    Console.WriteLine(Encoding.Default.GetString(buffer_receive));
}
catch (Exception)
{
    Console.WriteLine("Erro ao conectar no servidor\n");
    Console.WriteLine("Cheque se o server está online ou a porta esta aberta\n");
    return;
    //throw;

}


