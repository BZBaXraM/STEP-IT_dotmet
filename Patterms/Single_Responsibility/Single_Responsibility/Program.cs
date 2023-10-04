// #region Bad Example
// public class SendEmail
// {
//     public bool Send(string mail, string message)
//     {
//         if (!IsEmailAddressValid(mail)) return false;
//         return true;
//     }
//
//     public bool IsEmailAddressValid(string mail)
//     {
//         return true;
//     }
// }
// #endregion

SendEmail sendEmail = new SendEmail();
sendEmail.Send("baxram1997007@gmail.com", "Hi!");

#region God Example

public class MailAddressValidation
{
    public bool IsEmailAddressValid(string mail)
    {
        return true;
    }
}

public class SendEmail
{
    private MailAddressValidation _validation = new();

    public bool Send(string mail, string message)
    {
        if (!_validation.IsEmailAddressValid(mail)) return false;
        return true;
    }
}

#endregion