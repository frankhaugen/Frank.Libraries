using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Transform
{
    public Vector3 Position { get; set; } = Vector3.Zero;
    public Quaternion Rotation { get; set; } = Quaternion.Identity;
    public float Scale { get; set; } = 1f;
}