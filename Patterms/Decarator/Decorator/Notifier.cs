namespace Decorator;

public class Notifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Send message with E-mail");
    }
}