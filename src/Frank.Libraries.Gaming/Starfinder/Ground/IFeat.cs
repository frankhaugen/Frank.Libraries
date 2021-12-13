using System.Collections.Generic;

namespace Frank.Libraries.Gaming.Starfinder.Characters;

public interface IFeat
{
    string Name { get; set; }
    string Description { get; set; }
    public List<Prerequisite> Prerequisites { get; set; }
}