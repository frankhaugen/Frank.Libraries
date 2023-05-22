namespace Frank.Libraries.Gaming.Common.Dice;

public class ModifierCollection : List<int>
{
    public ModifierCollection(params int[] modifiers) : base(modifiers)
    {
    }

    public int Roll() => this.Sum();
}