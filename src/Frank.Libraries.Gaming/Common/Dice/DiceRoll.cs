namespace Frank.Libraries.Gaming.Common.Dice;

public struct DiceRoll
{
    public DiceRoll(DiceCollection diceCollection, ModifierCollection modifierCollection)
    {
        DiceCollection = diceCollection;
        ModifierCollection = modifierCollection;
    }

    public DiceCollection DiceCollection { get; private set; }
    public ModifierCollection ModifierCollection { get; private set; }
}