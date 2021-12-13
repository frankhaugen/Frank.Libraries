using Frank.Libraries.Gaming.Starfinder.Characters.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Characters;

public readonly record struct Skill(SkillName Name, int Ranks, int ClassBonus, int AbilityModifier);