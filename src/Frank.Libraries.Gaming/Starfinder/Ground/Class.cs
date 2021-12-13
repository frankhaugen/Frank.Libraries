using System.Collections.Generic;
using Frank.Libraries.Gaming.Starfinder.Characters.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Characters;

public abstract class Class
{
    public string Description { get; set; }
    public Dictionary<Level, ClassLevel> Levels { get; set; }
}