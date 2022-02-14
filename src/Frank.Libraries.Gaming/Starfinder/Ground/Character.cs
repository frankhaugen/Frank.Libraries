namespace Frank.Libraries.Gaming.Starfinder.Characters;

public class Character
{
    public string Name { get; set; }
    public string PlayerName { get; set; }
    public int Levels { get; set; }
    public Abilities Abilities { get; set; }
    public Saves Type { get; set; }
}

public readonly record struct Saves(Abilities Abilities);