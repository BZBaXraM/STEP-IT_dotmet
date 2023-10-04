using System.Net;
using System.Net.Sockets;
using System.Text;

var listener = new Socket(
    AddressFamily.InterNetwork, 
    SocketType.Dgram, 
    ProtocolType.Udp);

IPAddress.TryParse("127.0.0.1", out var ip);
var listenerEP = new IPEndPoint(ip, 27001);
listener.Bind(listenerEP);

var buffer = new byte[ushort.MaxValue];

EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);

while (true)
{
    var len = listener.ReceiveFrom(buffer, ref endPoint);
    var message = Encoding.Default.GetString(buffer, 0, len);
    #region from readline
    //Console.WriteLine($"{endPoint}: {message}");
    #endregion

    #region fake stream
    Console.Write($"{message}");
    #endregion
}
