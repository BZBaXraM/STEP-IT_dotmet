using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System.Net;
using System.Net.Mail;

//SMTP();
IMAP();

void SMTP()
{
    var client = new SmtpClient("smtp.gmail.com", 587);
    client.EnableSsl = true;

    client.Credentials = new NetworkCredential(
        "4211ru@gmail.com",
        "yxwxyeesklinyktm");
    
    var message = new MailMessage()
    {
        Subject = "For smtp test",
        Body = "Salam. Lorem ipsum dolor sit amet."
    };

    message.From = new MailAddress("4211ru@gmail.com", "4211_ru Network Programming");
    message.To.Add(new MailAddress("zamanov@itstep.org"));
    message.To.Add(new MailAddress("sahib.shakhayev@hotmail.com"));

    client.Send(message);
}

void IMAP()
{
    var imapClient = new ImapClient();
    imapClient.Connect("imap.gmail.com", 993, true);
    imapClient.Authenticate(
        "4211ru@gmail.com", // P@ss8520
        "yxwxyeesklinyktm");

    var inbox = imapClient.GetFolder("Inbox");
    inbox.Open(FolderAccess.ReadWrite);
    #region For read

    //var ids = inbox.Search(SearchQuery.All);

    //foreach (var id in ids)
    //{
    //    Console.WriteLine($"{id} {inbox.GetMessage(id).TextBody}");
    //}
    #endregion

    #region For Delete
    inbox.SetFlags(new List<int> { 1 }, MessageFlags.Deleted, true);
    inbox.Expunge();

    #endregion

}
