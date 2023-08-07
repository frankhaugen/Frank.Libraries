namespace Frank.Libraries.Gaming.Common.Dice;

public interface IDie
{
    int Sides { get; }
    public int Roll() => Random.Shared.Next(1, Sides + 1);
}