Client client = new Client();
Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy proxy = new Proxy(realSubject);
client.ClientCode(proxy);

public interface ISubject
{
    void Request();
}

class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("Реальный объект обработал запрос");
    }
}

class Proxy : ISubject
{
    private RealSubject _realSubject;
    private List<RealSubject> _logging;

    public Proxy(RealSubject realSubject)
    {
        _realSubject = realSubject;
    }

    public void Request()
    {
        if (CheckAccess())
        {
            _realSubject.Request();

            LogAccess();
        }
    }

    private bool CheckAccess()
    {
        Console.WriteLine("Proxy: Проверка достоупа к реальному объекта");
        return true;
    }

    private void LogAccess()
    {
        Console.WriteLine("Proxy: Сохранение доступа к реальному объекту");
    }

    public void ShowLog()
    {
    }
}

class Client
{
    public void ClientCode(ISubject subject)
    {
        subject.Request();
    }
}