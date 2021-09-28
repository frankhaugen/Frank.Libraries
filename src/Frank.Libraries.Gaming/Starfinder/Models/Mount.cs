using Frank.Libraries.Gaming.Starfinder.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Models
{
    public class Mount
    {
        public WeaponSize WeaponSize { get; set; }
        public Arc Arc { get; set; }

        public Weapon? Weapon { get; set; }
    }
}