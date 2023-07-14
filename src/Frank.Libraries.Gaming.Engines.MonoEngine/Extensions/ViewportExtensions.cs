using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class ViewportExtensions
{
    public static Vector2 GetCenter(this Viewport viewport) => new(viewport.Width / 2f, viewport.Height / 2f);

    public static Vector2 GetTopLeft(this Viewport viewport) => new(0, 0);

    public static Vector2 GetTopRight(this Viewport viewport) => new(viewport.Width, 0);

    public static Vector2 GetBottomLeft(this Viewport viewport) => new(0, viewport.Height);

    public static Vector2 GetBottomRight(this Viewport viewport) => new(viewport.Width, viewport.Height);

    public static Vector2 GetTopCenter(this Viewport viewport) => new(viewport.Width / 2f, 0);

    public static Vector2 GetBottomCenter(this Viewport viewport) => new(viewport.Width / 2f, viewport.Height);

    public static Vector2 GetLeftCenter(this Viewport viewport) => new(0, viewport.Height / 2f);

    public static Vector2 GetRightCenter(this Viewport viewport) => new(viewport.Width, viewport.Height / 2f);

    public static Vector2 GetRandomPosition(this Viewport viewport) => new(Random.Shared.Next(0, viewport.Width), Random.Shared.Next(0, viewport.Height));
}