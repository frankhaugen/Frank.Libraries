using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Ground;

public readonly record struct Prerequisite(int Ranks, SkillName Skill);