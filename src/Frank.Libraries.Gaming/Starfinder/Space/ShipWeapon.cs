namespace Frank.Libraries.Gaming.Starfinder.Space;

public record ShipWeapon
{
    public string Name { get; set; }
    public string Type { get; set; }
    public Range Range { get; set; }
    public string SpeedinHexes { get; set; }
    public string Damage { get; set; }
    public string PCU { get; set; }
    public int CostinBP { get; set; }
    public string SpecialProperties { get; set; }
}