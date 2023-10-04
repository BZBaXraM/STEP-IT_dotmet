namespace Builder;

internal class Program
{
    static void Main()
    {
        IHouseBuilder builder = new WoodHouseBuilder();
        builder.BuildWindows(4).BuildDoors(5).BuildGarage().BuildWalls(7);

        House house = builder.Build();
        Console.WriteLine(house);
    }
}