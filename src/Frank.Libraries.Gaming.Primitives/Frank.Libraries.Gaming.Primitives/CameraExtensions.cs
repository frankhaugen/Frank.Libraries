using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class CameraExtensions
{
    public static Matrix4x4 GetProjectionMatrix(this Camera camera)
    {
        var projectionMatrix = Matrix4x4.CreatePerspectiveFieldOfView(
            ToRadians(camera.FieldOfView),
            camera.AspectRatio,
            camera.NearPlaneDistance,
            camera.FarPlaneDistance);

        return projectionMatrix;
    }

    private static float ToRadians(this float degrees) => degrees * (MathF.PI / 180f);

    public static Matrix4x4 GetViewMatrix(this Camera camera)
    {
        var viewMatrix = Matrix4x4.CreateLookAt(
            camera.Position,
            camera.Target,
            camera.Up);

        return viewMatrix;
    }
}