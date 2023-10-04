using Decorator;

while (true)
{
    INotifier notifier = new Notifier();
    notifier = new WhatsappDecorator(notifier);
    notifier = new TelegramDecorator(notifier);
    notifier = new SMSDecorator(notifier);

    string message = Console.ReadLine()!;
    Console.Clear();
    notifier.Send(message);
}