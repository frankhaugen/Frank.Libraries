using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class PolygonExtensions
{
    public static Polygon Translate(this Polygon polygon, Vector3 position)
    {
        var vertices = new Vector3[polygon.Length];
        for (var i = 0; i < polygon.Length; i++)
        {
            vertices[i] = (polygon[i] += position);
        }

        return new Polygon(vertices);
    }

    public static Polygon Rotate(this Polygon polygon, Quaternion rotation)
    {
        var vertices = new Vector3[polygon.Length];
        for (var i = 0; i < polygon.Length; i++)
        {
            vertices[i] = Vector3.Transform(polygon[i], rotation);
        }
        return new Polygon(vertices);
    }

    public static Polygon Scale(this Polygon polygon, float scale)
    {
        var vertices = new Vector3[polygon.Length];
        for (var i = 0; i < polygon.Length; i++)
        {
            vertices[i] = polygon[i] * scale;
        }
        return new Polygon(vertices);
    }
}