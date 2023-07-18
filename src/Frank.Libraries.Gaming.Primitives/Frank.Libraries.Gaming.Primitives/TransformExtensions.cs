using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class TransformExtensions
{
    public static void Translate(this Transform transform, Vector3 position)
    {
        transform.Position += position;
    }

    public static void Rotate(this Transform transform, Vector3 radians)
    {
        transform.Rotation *= Quaternion.CreateFromYawPitchRoll(radians.X, radians.Y, radians.Z);
    }

    public static void ScaleBy(this Transform transform, float scale)
    {
        transform.Scale *= scale;
    }
}