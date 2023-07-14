using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine;

public static class WorldState
{
    public static Rectangle Bounds { get; set; }

    public static Rectangle PlayArea { get; set; }

    public static Vector3 Origin { get; set; } = Vector3.Zero;

    public static int AiPoints { get; set; } = 0;

    public static int PlayerPoints { get; set; } = 0;

    public const float DefaultCameraDistance = 1500f;

    public const float PaddleSpeed = 15f;

    public const float BallSpeed = 1f;

    public const float PysicsSpeed = 1f; // 1f = 1 iteration per millisecond


    public static Vector3 DefaultCameraPosition { get; set; } = Vector3.Backward * DefaultCameraDistance;
}