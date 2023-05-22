using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Ground;

public abstract class ClassLevel
{
    public Level Level { get; set; }
    public int BaseAttackBonus { get; set; }
    public int FortSaveBonus { get; set; }
    public int RefSaveBonus { get; set; }
    public int WillSaveBonus { get; set; }
    public string ClassFeatures { get; set; }
}