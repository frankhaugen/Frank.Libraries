using Frank.Libraries.Gaming.Starfinder.Common;
using Frank.Libraries.Gaming.Starfinder.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Models
{
    public class CrewMember
    {
        public Role Role { get; set; }
        public Character Character { get; set; }
    }
}