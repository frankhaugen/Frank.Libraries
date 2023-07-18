using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;

public static class Vector2Extensions
{
    public static bool IsColliding(this Vector2 vertex) => vertex.X < 0 || vertex.X > 800 || vertex.Y < 0 || vertex.Y > 600;

    public static Vector2 Rotate(this Vector2 vertex, float angle) => Vector2.Transform(vertex, Matrix.CreateRotationZ(angle));

    public static Vector3 ToVector3(this Vector2 vertex) => new(vertex.X, vertex.Y, 0);
    public static Vector3 ToVector3(this Vector2 vertex, float y) => new(vertex.X, vertex.Y, y);
}