using System.Security.Cryptography;

namespace Frank.Libraries.Gaming.Starfinder.Common
{
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