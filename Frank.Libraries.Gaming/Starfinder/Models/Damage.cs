using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Frank.Libraries.Gaming.Starfinder.Models
{
    public class Damage
    {
        private readonly List<int> _rolls = new();

        public Damage(int diceCount, int sideCount, int multiplier = 0)
        {
            DiceCount = diceCount;
            SideCount = sideCount;
            Multiplier = multiplier;
        }

        public int DiceCount { get; }
        public int SideCount { get; }
        public int Multiplier { get; }

        public int Roll()
        {
            for (var i = 0; i < DiceCount; i++)
            {
                _rolls.Add(RandomNumberGenerator.GetInt32(1, SideCount + 1));
            }

            return _rolls.Sum() * Multiplier;
        }
    }
}