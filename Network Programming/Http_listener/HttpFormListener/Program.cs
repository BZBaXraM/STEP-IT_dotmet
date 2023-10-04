using System.Net;

var listener = new HttpListener();
listener.Prefixes.Add("http://localhost:27001/");

listener.Start();

while (true)
{
    var context = listener.GetContext();
    var request = context.Request;
    var response = context.Response;
    StreamWriter stream = new(response.OutputStream);

    var username = context.Request.QueryString["name"];
    var pass = context.Request.QueryString["pass"];
    Console.WriteLine(username);
    Console.WriteLine(pass);
    if (username == "Nadir" && pass == "123456")
    {
        stream.WriteLine($"<h1 style='color:magenta;'>Welcome {username}</h1>");
    }

    else
    {
        stream.WriteLine($"<h1 style='color:red;'>Incorrect login or password</h1>");
    } 
    stream.Close();
}