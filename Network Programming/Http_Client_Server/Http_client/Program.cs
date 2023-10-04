using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

#region HttpClient
//HttpClient client = new HttpClient();

//var message = new HttpRequestMessage
//{
//    Method = HttpMethod.Get,
//    RequestUri = new Uri(@"https://www.google.com/"),
//};

//message.Headers.Add("Accept", "text/html");



//var response = await client.SendAsync(message);

//Console.WriteLine(response);
//Console.WriteLine(response.Headers);
//Console.WriteLine(response.StatusCode);
//Console.WriteLine(response.Content);
//Console.WriteLine(response.RequestMessage);


// .GetAsync(), .PostAsync(), .DeleteAsync() ....
//var result = await client.GetAsync(@"https://www.google.com/");
//Console.WriteLine(result);


//var page = await response.Content.ReadAsStringAsync();
//Console.WriteLine(page);


// Http + Ftp
//var webClient = new WebClient();
//Console.WriteLine(webClient.DownloadString("https://www.google.com/"));
#endregion

HttpClient client = new HttpClient();

var message = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri(@"https://jsonplaceholder.typicode.com/posts"),
};

var responce = await client.SendAsync(message);
//Console.WriteLine(responce);
var json = await responce.Content.ReadAsStringAsync();
//var post1 = JsonSerializer.Deserialize<Post>(json);
//Console.WriteLine(post1.body);
var posts = JsonSerializer.Deserialize<List<Post>>(json);

foreach (var post in posts!)
{
    Console.WriteLine(post.Text);
}

public class Post
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("body")]
    public string Text { get; set; }
}

