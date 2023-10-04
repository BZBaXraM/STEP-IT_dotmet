using System.Net;
using System.Net.Sockets;
using System.Text;


var client = new UdpClient();

var connectEP = new IPEndPoint(IPAddress.Loopback, 27001);
var str = string.Empty;

while (true)
{
    Task.Run(() =>
    {
        str = Console.ReadLine();
        var bytes = Encoding.Default.GetBytes(str!);
        client.Send(bytes, bytes.Length, connectEP);
    });
}

