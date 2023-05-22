using Frank.Libraries.Gaming.Starfinder.Ground;

namespace Frank.Libraries.Gaming.Starfinder;

public class CharacterController
{
    public CharacterController(Character character) => Character = character;

    public Character Character { get; }
}