using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades.Shapes;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades;

public class Ball : GameObject, IBounceable
{
    public Ball(int radius, Color color) : base(new Circle(radius, color))
    {
    }

    public override string Name { get; set; } = "Ball";
}