using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;
using Frank.Libraries.Gaming.Starfinder.Utilities;

namespace Frank.Libraries.Gaming.Starfinder.Extensions;

public static class DiceExtensions
{
    public static int GetInt(this Dice dice) => (int)dice;
    public static int Roll(this Dice dice, int count = 1) => DiceRoller.Roll(dice, count);
}