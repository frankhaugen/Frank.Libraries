using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Rendering;

public record Camera
{
    public Vector3 Position { get; set; } = WorldState.DefaultCameraPosition;

    public Vector3 Target { get; set; } = WorldState.Bounds.GetCenter()
                                                    .ToVector3();

    public float AspectRatio { get; set; } = 1.6666666666f;

    public Vector3 Up { get; } = Vector3.Up;
    public float NearPlaneDistance { get; } = 500f;
    public float FarPlaneDistance { get; } = 10_000f;
    public float FieldOfView { get; } = MathHelper.PiOver4;

    public Matrix ViewMatrix => Matrix.CreateLookAt(Position, Target, Up);

    // public Matrix ProjectionMatrix => Matrix.CreateOrthographic(WorldState.Bounds.Width, WorldState.Bounds.Height, NearPlaneDistance, FarPlaneDistance);
    public Matrix ProjectionMatrix => Matrix.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlaneDistance, FarPlaneDistance);

    public override string ToString() => $"Position: {Position}\nTarget: {Target}\nAspectRatio: {AspectRatio:N}";
}