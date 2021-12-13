using System.Collections.Generic;

namespace Frank.Libraries.Gaming.Starfinder.Space;

public class PowerCore
{
    public string Name { get; set; }
    public List<ShipSize> Sizes { get; set; }
    public int PCU { get; set; }
    public int Cost { get; set; }
}