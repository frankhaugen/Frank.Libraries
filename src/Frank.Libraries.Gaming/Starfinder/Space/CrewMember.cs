using Frank.Libraries.Gaming.Starfinder.Characters;
using Frank.Libraries.Gaming.Starfinder.Space.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Space;

public class CrewMember
{
    public Role Role { get; set; }
    public Character Character { get; set; }
}