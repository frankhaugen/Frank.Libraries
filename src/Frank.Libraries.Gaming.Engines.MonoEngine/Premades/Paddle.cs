using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades.Shapes;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades;

public class Paddle : GameObject, ICollidable
{
    public Paddle() : base(new Square(20, 75, Color.White))
    {
    }

    public override string Name { get; set; }

    public Rectangle GetCollider() => this.GetBounds();
}