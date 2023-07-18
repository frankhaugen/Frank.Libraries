using System.Collections.Concurrent;
using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public readonly record struct Face(Vector3 A, Vector3 B, Vector3 C);

public static class FaceFactory
{
    public static Face Create(Vector3 a, Vector3 b, Vector3 c) => new(a, b, c);

    public static IEnumerable<Face> CreateNormal(Polygon polygon, bool parallel = true)
    {
        return parallel
            ? CreateParallel(polygon)
            : CreateNormal(polygon);
    }

    public static IEnumerable<Face> CreateNormal(Polygon polygon)
    {
        var faces = new List<Face>();
        for (var i = 0; i < polygon.Length; i++)
        {
            var a = polygon[i];
            var b = polygon[(i + 1) % polygon.Length];
            var c = polygon.Position;
            faces.Add(new Face(a, b, c));
        }

        return faces;
    }

    public static IEnumerable<Face> CreateParallel(Polygon polygon)
    {
        var faces = new ConcurrentBag<Face>();
        Parallel.For(0, polygon.Length, i =>
        {
            var a = polygon[i];
            var b = polygon[(i + 1) % polygon.Length];
            var c = polygon.Position;
            faces.Add(new Face(a, b, c));
        });

        return faces;
    }
}

public static class FaceExtensions
{
    public static Vector3 GetNormal(this Face face)
    {
        var v1 = face.B - face.A;
        var v2 = face.C - face.A;
        var normal = Vector3.Cross(v1, v2);
        return Vector3.Normalize(normal);
    }
}