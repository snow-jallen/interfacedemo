namespace interfacedemo.logic;

public class Player : IGamePiece, ITakesHits, ICanAttack
{
    public Player(string name, string icon, int health, Location location)
    {
        Name = name;
        Icon = icon;
        Health = health;
        Location = location;
    }

    public string Name { get; }
    public string Icon { get; }
    public int Health { get; set;}
    public Location Location{get;set;}

    public void Attack(ITakesHits target)
    {
        target.Health -= 1;
    }
}

public class Structure : IGamePiece, ITakesHits
{
    public Structure(string name, string icon, int health, Location location)
    {
        Name = name;
        Icon = icon;
        Health = health;
        Location = location;
    }

    public string Name { get; }
    public string Icon { get; }
    public Location Location { get; set;}
    public int Health {get;set;}
}
