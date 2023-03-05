using System.Collections.Generic;
using Frank.Libraries.Gaming.Starfinder.Space.Models;
using Frank.Libraries.Gaming.Starfinder.Space.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Space.Constants;

public static class Frames
{
    public static Frame Racer => new(FrameName.Racer,
                                     ShipSize.Tiny,
                                     Maneuverability.Perfect,
                                     20,
                                     5,
                                     new List<Mount>
                                     {
                                         new(Arc.Forward,
                                             ShipWeaponSize.Light),
                                         new(Arc.Aft,
                                             ShipWeaponSize.Light)
                                     },
                                     new List<ExpansionBay>(),
                                     1,
                                     1,
                                     -1,
                                     4,
                                     4);

    public static Frame Explorer => new(FrameName.Explorer,
                                        ShipSize.Medium,
                                        Maneuverability.Good,
                                        55,
                                        10,
                                        new List<Mount>
                                        {
                                            new(Arc.Forward,
                                                ShipWeaponSize.Light),
                                            new(Arc.Aft,
                                                ShipWeaponSize.Light)
                                        },
                                        new List<ExpansionBay>(),
                                        1,
                                        1,
                                        -1,
                                        11,
                                        12);
}