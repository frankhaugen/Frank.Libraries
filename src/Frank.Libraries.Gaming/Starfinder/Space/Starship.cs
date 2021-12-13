using System.Collections.Generic;

namespace Frank.Libraries.Gaming.Starfinder.Space;

public class Starship : ShipBase
{
    public PowerCore PowerCore { get; set; }
    public ShieldGenerator ShieldGenerator { get; set; }
    public Computer Computer { get; set; }

    public List<ExpansionBay> ExpansionBays { get; set; }
    public List<Mount> Mounts { get; set; }

    public CrewMember Pilot { get; set; }
    public CrewMember Captain { get; set; }

    public List<CrewMember> Gunners { get; set; }
    public List<CrewMember> Engineers { get; set; }
    public List<CrewMember> ScienceOfficers { get; set; }
}