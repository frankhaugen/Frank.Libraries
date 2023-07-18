using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

public class PhysicalProperties
{
    public Vector2 Velocity { get; set; } = Vector2.Zero;
    public float Mass { get; set; } = 0f;
    public bool IsStatic { get; set; } = false;
    public bool IsBouncy { get; set; } = false;

    public bool IsCollider { get; set; }
}