public class Store : ISubject
{
    private List<IObserver> _subscribers = new List<IObserver>();
    private string? _productName { get; set; }
    private double _productPrice { get; set; }
    private bool _isAvailable;

    public bool IsAvailable
    {
        get { return _isAvailable; }
        set
        {
            _isAvailable = value;
            if (value)
            {
                Console.WriteLine("Продукт поступил!");
                Notify();
            }
            else
            {
                Console.WriteLine("Такого продукта нет!");
            }
        }
    }


    public Store(bool isAvailable, string? productName, double productPrice)
    {
        _isAvailable = isAvailable;
        _productName = productName;
        _productPrice = productPrice;
    }

    public void AddSubscriber(IObserver observer)
    {
        _subscribers.Add(observer);
        Console.WriteLine($"Новый клиент {observer.FullName} добавлен");
    }

    public void RemoveSubscriber(IObserver observer)
    {
        _subscribers.Remove(observer);
        Console.WriteLine($"Клиет {observer.FullName} удален");
    }

    public void Notify()
    {
        Console.WriteLine($"Продукт: {_productName} Цена: {_productPrice}");
        foreach (IObserver subscriber in _subscribers)
        {
            subscriber.Update(_isAvailable);
        }
    }
}