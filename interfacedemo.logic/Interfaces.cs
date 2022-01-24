namespace interfacedemo.logic;

public record Location(int Row, int Column);

public interface IGamePiece
{
    string Name{get;}
    string Icon{get;}
    Location Location{get;set;}
}

public interface ITakesHits
{
    int Health{get;set;}
}

public interface ICanAttack
{
    void Attack(ITakesHits target);
}
