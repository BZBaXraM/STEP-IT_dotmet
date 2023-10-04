using System.Net;
using System.Net.Sockets;
using System.Text;

var ipAdress = IPAddress.Parse("127.0.0.1");
var port = 27001;

Socket client = new Socket(
    AddressFamily.InterNetwork,
    SocketType.Stream,
    ProtocolType.Tcp);
var endpoint = new IPEndPoint(ipAdress, port);

var message = string.Empty;

try
{
    client.Connect(endpoint);
    if (client.Connected)
    {
        Console.WriteLine("Connected to server...");
        while (true)
        {
            message = Console.ReadLine();
            var bytes = Encoding.Default.GetBytes(message);
            client.Send(bytes);
        }
    }
    else
    {
        Console.WriteLine("Can not connected to server...");
    }
}
catch(Exception ex)
{
    Console.WriteLine("Can not connected to server...");
    Console.WriteLine(ex.Message);
}

