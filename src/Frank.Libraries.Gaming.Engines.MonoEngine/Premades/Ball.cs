using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Frank.Libraries.Gaming.Engines.MonoEngine.Premades.Shapes;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Premades;

public class Ball : GameObject, IBounceable
{
    public Ball(int radius, Color color) : base(new Circle(radius, color))
    {
    }

    public override string Name { get; set; } = "Ball";
}