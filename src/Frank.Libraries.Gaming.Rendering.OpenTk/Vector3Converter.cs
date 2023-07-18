using OpenTK.Mathematics;

namespace Frank.Libraries.Gaming.Rendering.OpenTk;

public static class Vector3Converter
{
    public static Vector3 ToVector3(System.Numerics.Vector3 source) => new(source.X, source.Y, source.Z);
    public static System.Numerics.Vector3 ToVector3(Vector3 source) => new(source.X, source.Y, source.Z);

}