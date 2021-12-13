using System;

namespace Frank.Libraries.Gaming.Starfinder.Space;

public enum ShipSize
{
    Tiny = 2,
    Small = 1,
    Medium = 0,
    Large = -1,
    Huge = -2,
    Gargantuan = -4,
    Colossal = -8
}

public readonly record struct ShipScale(ShipSize Size, Range Length, Range Weight);