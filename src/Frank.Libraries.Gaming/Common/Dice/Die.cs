namespace Frank.Libraries.Gaming.Common.Dice;

public class Die : IDie
{
    public Die(int sides)
    {
        Sides = sides;
    }

    public int Sides { get; }
}