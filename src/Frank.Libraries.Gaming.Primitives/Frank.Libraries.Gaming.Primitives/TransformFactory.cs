using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class TransformFactory
{
    public static Transform CreateTransform()
    {
        var transform = new Transform
        {
            Position = Vector3.Zero,
            Rotation = Quaternion.Identity,
            Scale = 1f
        };
        return transform;
    }

    public static Transform CreateTransform(Vector3 position, float scale = 1f)
    {
        var transform = new Transform
        {
            Position = position,
            Rotation = Quaternion.Identity,
            Scale = scale
        };
        return transform;
    }

    public static Transform CreateTransform(Vector3 position, Quaternion rotation, float scale = 1f)
    {
        var transform = new Transform
        {
            Position = position,
            Rotation = rotation,
            Scale = scale
        };
        return transform;
    }
}