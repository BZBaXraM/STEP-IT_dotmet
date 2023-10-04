namespace ExampleWithMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static async Task Main()
        {
            HttpClient client = new HttpClient();

            var message = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(@"https://www.google.com/"),
            };

            //message.Headers.Add("Accept", "text/html");



            var response = await client.SendAsync(message);
        }
    }
}