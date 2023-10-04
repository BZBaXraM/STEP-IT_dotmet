using System.Net;
using System.Net.Sockets;
using System.Text;

var client = new Socket(
    AddressFamily.InterNetwork,
    SocketType.Dgram,
    ProtocolType.Udp);
IPAddress.TryParse("127.0.0.1", out var ip);
var connectEP = new IPEndPoint(ip, 27001);
var message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus a cursus ante. Cras condimentum odio et porttitor fermentum. Nulla cursus ipsum lorem, eu porta ante congue nec. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce eget leo at eros dapibus pulvinar. Curabitur fermentum, lacus a porta convallis, risus augue lacinia dolor, eu maximus sem lorem eu neque. In ac sem suscipit, condimentum felis sed, tempor mauris. Cras at sodales felis.";
int count = 0;
Console.WriteLine(message.Length);
while (true)
{
    #region from readline
    //message = Console.ReadLine();
    //var bytes = Encoding.UTF8.GetBytes(message);
    #endregion

    #region fake stream
    var bytes = Encoding.UTF8.GetBytes(message[count++ % message.Length].ToString());
    //var bytes = Encoding.UTF8.GetBytes((count++ % message.Length).ToString());
    Thread.Sleep(100);
    #endregion
    client.SendTo(bytes, connectEP);
}

