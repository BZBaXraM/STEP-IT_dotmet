namespace Decorator;

public class SMSDecorator : BaseDecorator
{
    public SMSDecorator(INotifier notifier) : base(notifier)
    {
    }
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Send {message} with SMS");
    }
}