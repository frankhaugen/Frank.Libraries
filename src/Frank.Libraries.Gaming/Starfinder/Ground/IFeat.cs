namespace Frank.Libraries.Gaming.Starfinder.Ground;

public interface IFeat
{
    string Name { get; set; }
    string Description { get; set; }
    public List<Prerequisite> Prerequisites { get; set; }
}