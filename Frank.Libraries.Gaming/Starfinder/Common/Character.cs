using System.Collections.Generic;

namespace Frank.Libraries.Gaming.Starfinder.Common
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Ability Strength { get; set; }
        public Ability Dexterity { get; set; }
        public Ability Wisdom { get; set; }
        public Ability Intelligence { get; set; }
        public Ability Charisma { get; set; }

        public List<Class> Classes { get; set; }
        public List<Skill> Skills { get; set; }
    }
}