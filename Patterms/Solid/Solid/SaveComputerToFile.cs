namespace Solid;

public class SaveComputerToFile : ISaveComputer
{
    public void Save(string path, Computer comp)
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(path);
            writer.WriteLine(comp);
        }
        Console.WriteLine($"Save to file {path}, {comp}");
    }
}