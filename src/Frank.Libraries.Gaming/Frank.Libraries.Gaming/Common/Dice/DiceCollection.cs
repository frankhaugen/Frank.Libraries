namespace Frank.Libraries.Gaming.Common.Dice;

public class DiceCollection : List<IDie>
{
    public DiceCollection(params IDie[] dice) : base(dice)
    {
    }

    public int Roll() => this.Sum(d => d.Roll());
}