using System.Net;

var listener = new HttpListener();
listener.Prefixes.Add("http://localhost:27001/");
listener.Prefixes.Add("http://localhost:27002/");
listener.Prefixes.Add("http://localhost:27003/");
listener.Start();

while (true)
{
    var context = listener.GetContext();
    var request = context.Request;
    var response = context.Response;

    //Console.WriteLine(request.RawUrl);
    //foreach (string key in request.QueryString.Keys)
    //{
    //    //Console.WriteLine(key);
    //    Console.WriteLine($"{key} - {request.QueryString[key]}");
    //}
    response.AddHeader("Content-Type", "text/html");
    StreamWriter sw = new StreamWriter(response.OutputStream);
    //sw.WriteLine($"Hello, World! Hello {request.QueryString["name"]}");\
    sw.WriteLine("<h1 style='color:red;'>Lorem Ipsum Sit Dolor Amet</h1>");
    sw.WriteLine("<a href='https://google.com'>");
    sw.WriteLine("<img src='https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png'/>");
    sw.WriteLine("</a>");
    sw.Close();
    //sw.Flush();
    //response.Close();
}
