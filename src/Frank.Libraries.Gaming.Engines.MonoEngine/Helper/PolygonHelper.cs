using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Helper;

public static class PolygonHelper
{
    public static bool Intersects(Polygon polygon1, Polygon polygon2)
    {
        Vector2[] axes = GetAxes(polygon1)
                         .Concat(GetAxes(polygon2))
                         .ToArray();

        foreach (Vector2 axis in axes)
        {
            float min1 = float.MaxValue, max1 = float.MinValue;
            float min2 = float.MaxValue, max2 = float.MinValue;

            foreach (Vector2 vertex in polygon1)
            {
                float projection = Vector2.Dot(vertex, axis);
                min1 = Math.Min(min1, projection);
                max1 = Math.Max(max1, projection);
            }

            foreach (Vector2 vertex in polygon2)
            {
                float projection = Vector2.Dot(vertex, axis);
                min2 = Math.Min(min2, projection);
                max2 = Math.Max(max2, projection);
            }

            if (max1 < min2 || max2 < min1)
            {
                return false;
            }
        }

        return true;
    }

    private static Vector2[] GetAxes(Polygon polygon)
    {
        Vector2[] axes = new Vector2[polygon.Length];

        for (int i = 0; i < polygon.Length; i++)
        {
            Vector2 vertex1 = polygon[i];
            Vector2 vertex2 = polygon[(i + 1) % polygon.Length];
            Vector2 edge = vertex2 - vertex1;
            axes[i] = new Vector2(-edge.Y, edge.X);
            axes[i] = Vector2.Normalize(axes[i]);
        }

        return axes;
    }
}