using System.Security.Cryptography;
using Frank.Libraries.Gaming.Starfinder.Extensions;
using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Utilities;

public static class DiceRoller
{
    public static int Roll(Dice dice) => RandomNumberGenerator.GetInt32(1, dice.GetInt() + 1);

    public static int Roll(Dice dice, int count)
    {
        var result = 0;

        for (var i = 0; i < count; i++)
        {
            result += RandomNumberGenerator.GetInt32(1, dice.GetInt() + 1);
        }

        return result;
    }
}