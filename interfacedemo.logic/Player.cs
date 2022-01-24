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
