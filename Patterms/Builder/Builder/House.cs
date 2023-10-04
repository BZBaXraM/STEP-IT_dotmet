namespace Builder;

public class House
{
    public string? Name { get; set; }
    public int Walls { get; set; }
    public int Doors { get; set; }
    public int Windows { get; set; }
    public bool HasRoof { get; set; }
    public bool HasGarage { get; set; }
    public bool HasPool { get; set; }
    public bool HasGarden { get; set; }

    public override string ToString()
    {
        return $@"
                 Name: {Name}
                 Walls: {Walls}
                 Doors: {Doors}
                 Windows: {Windows}
                 HasRoof: {HasRoof}
                 HasGarage: {HasGarage}
                 HasPool: {HasPool}
                 HasGarden: {HasGarden}";
    }
}