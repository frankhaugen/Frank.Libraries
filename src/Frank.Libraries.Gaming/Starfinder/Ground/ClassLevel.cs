using Frank.Libraries.Gaming.Starfinder.Characters.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Characters;

public abstract class ClassLevel
{
    public Level Level { get; set; }
    public int BaseAttackBonus { get; set; }
    public int FortSaveBonus { get; set; }
    public int RefSaveBonus { get; set; }
    public int WillSaveBonus { get; set; }
    public string ClassFeatures { get; set; }
}