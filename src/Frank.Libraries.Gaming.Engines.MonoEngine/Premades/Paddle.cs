using Frank.Libraries.Gaming.Engines.MonoEngine.Collisions;
using Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Frank.Libraries.Gaming.Engines.MonoEngine.Premades.Shapes;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Premades;

public class Paddle : GameObject, ICollidable
{
    public Paddle() : base(new Square(20, 75, Color.White))
    {
    }

    public override string Name { get; set; }

    public Rectangle GetCollider() => this.GetBounds();
}