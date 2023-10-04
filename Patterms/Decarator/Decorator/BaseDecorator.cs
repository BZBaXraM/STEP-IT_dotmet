namespace Decorator;

public abstract class BaseDecorator : INotifier
{
    protected INotifier _notifier;

    protected BaseDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send(string message)
    {
        _notifier.Send(message);
    }
}