using System.Net;
using System.Net.Sockets;
using System.Text;

var client = new UdpClient();
IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 27001);
var animation = new List<string>
{
    @"________",
    @"\_______",
    @"/\______",
    @"_/\_____",
    @"__/\____",
    @"___/\___",
    @"____/\__",
    @"_____/\_",
    @"______/\",
    @"_______/"

};
int i = 0;

while (true)
{
    //var data = Encoding.Default.GetBytes(Console.ReadLine()!);
    //client.Send(data, endPoint);

    client.Send(Encoding.Default.GetBytes(animation[i++ % animation.Count]), endPoint);
    Thread.Sleep(40);        
}
