using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Ground;

public abstract class Class
{
    public string Description { get; set; }
    public Dictionary<Level, ClassLevel> Levels { get; set; }
}