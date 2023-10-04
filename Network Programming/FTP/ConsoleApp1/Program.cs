using System.Net;
//UploadFtp();
//getFtp();
DownloadFtp();
void getFtp()
{
    var request = WebRequest.Create("ftp://localhost:21") as FtpWebRequest;

    request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
    var response = request.GetResponse() as FtpWebResponse;

    var stream = response.GetResponseStream();
    var sr = new StreamReader(stream);
    var data = sr.ReadToEnd();
    Console.WriteLine(data);
}

void DownloadFtp()
{
    var request = WebRequest.Create("ftp://localhost:21/bahar.pdf") as FtpWebRequest;
    request.Method = WebRequestMethods.Ftp.DownloadFile;

    var response = request.GetResponse() as FtpWebResponse;
    var stream = response.GetResponseStream();
    var fs = new FileStream("sahar.pdf", FileMode.Create);
    stream.CopyTo(fs);
    stream.Close();
    fs.Close();


}

void UploadFtp()
{
    var request = WebRequest.Create("ftp://localhost:21/destination.txt") as FtpWebRequest;
    request.Method = WebRequestMethods.Ftp.UploadFile;
    var requestSteram = request.GetRequestStream();

    var fs = new FileStream("source.txt", FileMode.Open);
    fs.CopyTo(requestSteram);
    fs.Flush();
    fs.Close();
    requestSteram.Close();
}
