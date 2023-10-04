public class CustomerObserver : IObserver
{
    public string? FullName { get; set; }

    public void Update(bool isAvailable)
    {
        if (isAvailable)
        {
            Console.WriteLine($"Hi, {FullName}. " +
                              $"Вы ждали этого продукта. " +
                              $"Он поступил!");
        }
    }

    public CustomerObserver(string fullName, ISubject subject)
    {
        FullName = fullName;
        subject.AddSubscriber(this);
    }
}