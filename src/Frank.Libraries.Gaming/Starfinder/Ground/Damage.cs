using Frank.Libraries.Gaming.Starfinder.Characters.Models.Enums;
using Frank.Libraries.Gaming.Starfinder.Space.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Characters;

public readonly record struct Damage(Dice Dice, Range Range);