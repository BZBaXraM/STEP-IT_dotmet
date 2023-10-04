namespace Solid;

// Представляет сам объект
// Мы должны создавать классы, который реализует только свой функцианал
// Нужно разделять функцианал между разными классами
public class Computer
{
    protected string _name { get; set; }
    protected int _memorySize { get; set; }

    public Computer(string _name, int _memorySize)
    {
        this._name = _name;
        this._memorySize = _memorySize;
    }

    // public void SetData(string _name)
    // {
    //     this._name = _name;
    // }

    // Нарушает принцип единственной ответсвенности
    // public void Save()
    // {
    //     Console.WriteLine("Save object class to file");
    // }
    //
    // public void Load()
    // {
    //     Console.WriteLine("Load object class from file");
    // }
}