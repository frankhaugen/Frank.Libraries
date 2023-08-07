using Frank.Libraries.Gaming.Starfinder.Ground.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Ground;

public record CharacterBio(string Name, string PlayerName, int Age, Gender Gender, string? History = null)
{
}