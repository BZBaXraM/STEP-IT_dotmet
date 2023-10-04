public interface ISubject
{
    void AddSubscriber(IObserver observer);
    void RemoveSubscriber(IObserver observer);
    void Notify();
}