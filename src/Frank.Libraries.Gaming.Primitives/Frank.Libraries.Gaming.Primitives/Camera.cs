using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public record Camera
{
    public Vector3 Position { get; set; } = Vector3.UnitZ * -10;

    public Vector3 Target { get; set; } = Vector3.Zero;

    public float AspectRatio { get; set; } = 1.6666666666f;

    public Vector3 Up { get; } = Vector3.UnitZ;
    public float NearPlaneDistance { get; } = 500f;
    public float FarPlaneDistance { get; } = 10_000f;
    public float FieldOfView { get; } = Constants.MathConstants.PiOver4;

    public Matrix ViewMatrix => Matrix.CreateLookAt(Position, Target, Up);

    public Matrix ProjectionMatrix => Matrix.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlaneDistance, FarPlaneDistance);

    public override string ToString() => $"Position: {Position}\nTarget: {Target}\nAspectRatio: {AspectRatio:N}";
}