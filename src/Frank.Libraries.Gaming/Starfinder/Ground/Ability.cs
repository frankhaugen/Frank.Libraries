using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Ground;

public readonly record struct Ability(AbilityName Name, int Score)
{
    public int GetModifier() =>
        Score switch
        {
            0  => -5,
            1  => -5,
            2  => -4,
            3  => -4,
            4  => -3,
            5  => -3,
            6  => -2,
            7  => -2,
            8  => -1,
            9  => -1,
            10 => 0,
            11 => 0,
            12 => 1,
            13 => 1,
            14 => 2,
            15 => 2,
            16 => 3,
            17 => 3,
            18 => 4,
            19 => 4,
            20 => 5,
            21 => 5,
            22 => 6,
            23 => 6,
            24 => 7,
            25 => 7,
            _  => throw new ArgumentOutOfRangeException(nameof(Score), $"{nameof(Score)}'s value {Score} is out of range")
        };
}