namespace Frank.Libraries.Gaming.Starfinder.Ground;

public abstract class Feat
{
    public string Name { get; set; }
    public FeatCategory Category { get; set; }
    public string Prerequisites { get; set; }
    public string Benefit { get; set; }
    public string Source { get; set; }
}