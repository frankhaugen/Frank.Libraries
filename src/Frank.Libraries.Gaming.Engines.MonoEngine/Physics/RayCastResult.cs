using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Physics;

public readonly struct RayCastResult
{
    /// <summary>
    /// The position of the ray hit
    /// </summary>
    public Ray Origin { get; }

    public Vector2 Normal { get; }
    public float Distance { get; }

    public string? Name { get; }

    public RayCastResult(Ray origin, Vector2 normal, float distance, string? name)
    {
        Origin = origin;
        Normal = normal;
        Distance = distance;
        Name = name;
    }
}