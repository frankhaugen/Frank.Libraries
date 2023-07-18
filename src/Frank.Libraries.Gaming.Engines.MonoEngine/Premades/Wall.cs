using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Premades;

public class Wall : GameObject
{
    public Wall(Shape shape) : base(shape)
    {
    }

    public override string Name { get; set; }
}