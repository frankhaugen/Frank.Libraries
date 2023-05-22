using Frank.Libraries.Gaming.Starfinder.Space.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Space.Models;

public record Frame(FrameName Name,
                    ShipSize Size,
                    Maneuverability Maneuverability,
                    int HitPoints,
                    int HitPointIncrement,
                    List<Mount> Mounts,
                    List<ExpansionBay> ExpansionBays,
                    int MinimumCrew,
                    int MaximumCrew,
                    int DamageThreshold,
                    int CriticalThreshold,
                    int Cost
);