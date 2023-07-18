using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

public class Transform
{
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Quaternion Rotation { get; set; } = Quaternion.Identity;
    public float Scale { get; set; } = 1f;

    public void Translate(Vector2 position)
    {
        Position += position;
    }

    public void Rotate(Vector2 radians)
    {
        Rotation *= Quaternion.CreateFromYawPitchRoll(radians.X, radians.Y, 0);
    }

    public void ScaleBy(float scale)
    {
        Scale *= scale;
    }
}