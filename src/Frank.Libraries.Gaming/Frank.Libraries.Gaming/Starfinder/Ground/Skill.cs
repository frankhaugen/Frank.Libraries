using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Ground;

public readonly record struct Skill(SkillName Name, int Ranks, int ClassBonus, int AbilityModifier);