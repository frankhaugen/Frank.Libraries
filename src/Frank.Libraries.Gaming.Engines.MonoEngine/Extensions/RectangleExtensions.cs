using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class RectangleExtensions
{
    public static Vector2 GetHalfExtents(this Rectangle rectangle)
    {
        return new Vector2(rectangle.Width / 2f, rectangle.Height / 2f);
    }

    public static Vector2 GetTopLeft(this Rectangle rectangle) => new(rectangle.X, rectangle.Y);

    public static Vector2 GetTopRight(this Rectangle rectangle) => new(rectangle.X + rectangle.Width, rectangle.Y);

    public static Vector2 GetBottomLeft(this Rectangle rectangle) => new(rectangle.X, rectangle.Y + rectangle.Height);

    public static Vector2 GetBottomRight(this Rectangle rectangle) => new(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);

    public static Vector2 GetTopCenter(this Rectangle rectangle) => new(rectangle.X + rectangle.Width / 2f, rectangle.Y);

    public static Vector2 GetBottomCenter(this Rectangle rectangle) => new(rectangle.X + rectangle.Width / 2f, rectangle.Y + rectangle.Height);

    public static Vector2 GetLeftCenter(this Rectangle rectangle) => new(rectangle.X, rectangle.Y + rectangle.Height / 2f);

    public static Vector2 GetRightCenter(this Rectangle rectangle) => new(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height / 2f);

    public static Vector2 GetCenter(this Rectangle rectangle) => new(rectangle.X + rectangle.Width / 2f, rectangle.Y + rectangle.Height / 2f);

    public static Vector2 GetRandomPosition(this Rectangle rectangle) => new(Random.Shared.Next(rectangle.X, rectangle.X + rectangle.Width), Random.Shared.Next(rectangle.Y, rectangle.Y + rectangle.Height));

    public static Vector2 GetPosition(this Rectangle rectangle) => new(rectangle.X, rectangle.Y);
}