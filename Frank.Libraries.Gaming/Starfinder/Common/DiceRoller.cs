using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;

namespace Frank.Libraries.Gaming.Starfinder.Common
{
    public class DiceRoller
    {
        public static int RollDice(params (int, Dice)[] rolls)
        {
            var result = 1;
            foreach (var (item1, item2) in rolls)
            {
                var rollResult = new Roll(item1, item2);
                result += rollResult.GetResult();
            }

            return result;
        }
    }

    public record Roll
    {
        public readonly int Count;
        public readonly Dice Dice;
        public readonly IReadOnlyList<RollResult> Results;

        public Roll([Range(1, int.MaxValue)] int count = 1, Dice dice = Dice.Icasahedron)
        {
            Count = count;
            Dice = dice;

            var rolls = new List<RollResult>();

            for (var i = 0; i < count; i++)
            {
                rolls.Add(new RollResult(Dice));
            }

            Results = rolls;
        }

        public int GetResult() => Results.Select(x => x.Result).Sum();
    }

    public enum Dice
    {
        Tetrahedron = 4,
        Cube = 6,
        Octahedron = 8,
        PentagonalTrapezohedron = 10,
        Dodecahedron = 12,
        Icasahedron = 20,
        Zocchihedron = 100
    }

    public record RollResult
    {
        public readonly Dice Dice;
        public readonly int Result;

        public RollResult(Dice dice = Dice.Icasahedron)
        {
            Dice = dice;
            Result = RandomNumberGenerator.GetInt32(1, (int)Dice + 1);
        }
    }
}