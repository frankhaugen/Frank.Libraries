using Frank.Libraries.Gaming.Starfinder.Characters.Models.Enums;

namespace Frank.Libraries.Gaming.Starfinder.Characters;

public record CharacterBio(string Name, string PlayerName, int Age, Gender Gender, string? History = null)
{

}