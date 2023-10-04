interface IDb
{
    void Read();
    void Modifier();
    void Remove();
    void Create();
}

class PostgreSQL: IDb
{
    public void Read() => Console.WriteLine("Read with PostgreSQL");
    public void Modifier() => Console.WriteLine("Modifier with PostgreSQL");
    public void Remove() => Console.WriteLine("Remove with PostgreSQL");
    public void Create() => Console.WriteLine("Create with PostgreSQL");
}

class MySql: IDb
{
    public void Read() => Console.WriteLine("Read with MySql");
    public void Modifier() => Console.WriteLine("Modifier with MySql");
    public void Remove() => Console.WriteLine("Remove with MySql");
    public void Create() => Console.WriteLine("Create with MySql");
}


class Application
{
    private IDb _db;

    public Application(IDb db)
    {
        _db = db;
    }
    public void DoSomething()
    {
        _db.Create();
        _db.Read();
        _db.Modifier();
        _db.Remove();
    }
}