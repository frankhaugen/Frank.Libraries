using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;

public static class Vector3Extensions
{
    public static bool IsColliding(this Vector3 vertex) => vertex.X < 0 || vertex.X > 800 || vertex.Y < 0 || vertex.Y > 600;

    public static Vector3 Rotate(this Vector3 vertex, float angle) => Vector3.Transform(vertex, Matrix.CreateRotationZ(angle));

    public static Vector2 ToVector2(this Vector3 vertex) => new(vertex.X, vertex.Y);
}