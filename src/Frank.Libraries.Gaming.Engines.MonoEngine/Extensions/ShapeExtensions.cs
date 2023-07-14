using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class ShapeExtensions
{
    public static Rectangle GetBounds(this Shape shape)
    {
        var size = shape.Size;
        var position = Vector2.Zero;
        return new Rectangle((int)position.X, (int)position.Y, size.Width, size.Height);
    }
}