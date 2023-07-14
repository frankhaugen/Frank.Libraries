using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades;

public class Wall : GameObject
{
    public Wall(Shape shape) : base(shape)
    {
    }

    public override string Name { get; set; }
}