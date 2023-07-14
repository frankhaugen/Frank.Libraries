using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Transform2D
{
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Quaternion Rotation { get; set; } = Quaternion.Identity;
    public float Scale { get; set; } = 1f;
}