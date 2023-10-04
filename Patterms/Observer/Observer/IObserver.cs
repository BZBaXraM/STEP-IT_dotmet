public interface IObserver
{
    string? FullName { get; set; }
    void Update(bool isAvailable);
}