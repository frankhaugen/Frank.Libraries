using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class Transform2DExtensions
{
    public static void Translate(this Transform2D transform, Vector2 position)
    {
        transform.Position += position;
    }

    public static void Rotate(this Transform2D transform, Vector2 radians)
    {
        transform.Rotation *= Quaternion.CreateFromYawPitchRoll(radians.X, radians.Y, 0);
    }

    public static void ScaleBy(this Transform2D transform, float scale)
    {
        transform.Scale *= scale;
    }
}