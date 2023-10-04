namespace Solid;

public class SaveComputerToDB : ISaveComputer
{
    public void Save(string path, Computer comp)
    {
        Console.WriteLine($"Save to DB {path}, {comp}");
    }
}