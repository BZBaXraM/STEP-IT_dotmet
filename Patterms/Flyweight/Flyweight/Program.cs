FlyWeightFactory factory = new();
List<Player?> players = new();
for (int i = 0; i < 100; i++)
{
    //players.Add(new Archer());
    //players.Add(new Warrior());

    players.Add(factory?.GetUnit("Archer"));
    players.Add(factory?.GetUnit("Warrior"));
    Console.WriteLine(players.Last());
}

Console.WriteLine("Terminated");

abstract class Player
{
    public string? Name { get; set; }
    public int AttackPoint { get; set; }
    public short Health { get; set; }

    public abstract void Display();
}

class Archer : Player
{
    public Archer()
    {
        Name = "Archer";
        AttackPoint = 4;
        Health = 450;
    }

    public override void Display()
    {
        Console.WriteLine("Archer created");
        ;
    }
}

class Warrior : Player
{
    public Warrior()
    {
        Name = "Warrior";
        AttackPoint = 79;
        Health = 100;
    }

    public override void Display()
    {
        Console.WriteLine("Warrior created");
    }
}

class FlyWeightFactory
{
    private Dictionary<string, Player?> _units = new();

    public Player? GetUnit(string key)
    {
        Player? unit = null;
        if (_units.ContainsKey(key))
        {
            unit = _units[key];
        }
        else
        {
            switch (key)
            {
                case "Archer":
                    unit = new Archer();
                    break;
                case "Warrior":
                    unit = new Warrior();
                    break;
            }

            _units.Add(key, unit);
        }

        return unit;
    }
}