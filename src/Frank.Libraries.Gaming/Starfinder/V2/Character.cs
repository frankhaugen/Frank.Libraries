using System.Collections.Generic;

namespace Frank.Libraries.Gaming.Starfinder.V2;

public class Character
{
    public string Name { get; set; }
    public string PlayerName { get; set; }
    public int Levels { get; set; }

}

public readonly record struct Levels(int Value, Class Class);

public readonly record struct Prerequisite(int Ranks, SkillName Skill);

public abstract class PlayerClass
{
    public string Name { get; set; }
    public Class Class { get; set; }

}

public enum Class
{
    Soldier,
    Mystic
}

public interface IFeat
{
    string Name { get; set; }
    string Description { get; set; }
    public List<Prerequisite> Prerequisites { get; set; }

}


