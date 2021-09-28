using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Frank.Libraries.Gaming.Starfinder.Common
{
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
}