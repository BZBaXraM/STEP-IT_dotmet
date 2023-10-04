namespace Decorator;

public class WhatsappDecorator : BaseDecorator
{
    public WhatsappDecorator(INotifier notifier) : base(notifier) {}

    public override void Send(string message)
    {
        Console.WriteLine($"Send {message} with Whatsapp");
    }
}