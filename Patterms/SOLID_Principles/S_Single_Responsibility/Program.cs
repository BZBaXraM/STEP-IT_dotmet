// bad example

//public class SendEmail
//{
//    public bool IsMailAddressValid(string mail)
//    {
//        // some code for check validaton (regex)
//        return true;
//    }
//    public bool Send(string mail, string message)
//    {
//        if (IsMailAddressValid(mail)) return true;
//        return false;
//    }
//}


// Good example

//public class MailAddressValidation
//{
//    public bool IsMailAddressValid(string mail)
//    {
//        // some code for check validaton (regex)
//        return true;
//    }
//}

//class SendEmail
//{
//    private MailAddressValidation _validation = new();
//    public bool Send (string mail, string message)
//    {
//        if (_validation.IsMailAddressValid(mail)) return true;
//        return false;
//    }
//}


