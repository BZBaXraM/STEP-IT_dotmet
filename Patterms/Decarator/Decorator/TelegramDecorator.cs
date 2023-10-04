namespace Decorator;

public class TelegramDecorator : BaseDecorator
{
    public TelegramDecorator(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Send {message} with Telegram");
    }
}