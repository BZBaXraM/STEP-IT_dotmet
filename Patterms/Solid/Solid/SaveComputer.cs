namespace Solid;
// Каждый класс отвечает за свою сферу деятельности - 1
class SaveComputer
{
    public void SaveToFile(string path, Computer comp)
    {
        //Console.WriteLine($"Save to file {path }, {comp}");
    }
    
    public void SaveToDB(string path, Computer comp)
    {
        Console.WriteLine($"Save to DB {path }, {comp}");
    }
    
}