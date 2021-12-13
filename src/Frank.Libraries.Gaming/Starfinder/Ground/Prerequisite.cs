using Frank.Libraries.Gaming.Starfinder.Characters.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Characters;

public readonly record struct Prerequisite(int Ranks, SkillName Skill);