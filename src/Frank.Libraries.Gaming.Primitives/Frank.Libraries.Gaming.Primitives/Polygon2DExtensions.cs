using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class Polygon2DExtensions
{
    /// <summary>
    /// Returns the edges of the polygon. The last edge is from the last vertex to the first.
    /// </summary>
    /// <param name="polygon"></param>
    /// <returns></returns>
    public static IEnumerable<Edge2D> GetEdges(this Polygon2D polygon)
    {
        var edges = new Edge2D[polygon.Length];
        for (var i = 0; i < polygon.Length; i++) edges[i] = new Edge2D(polygon[i], polygon[(i + 1) % polygon.Length]);
        return edges;
    }

    /// <summary>
    /// Returns true if the two polygons are colliding. If they are colliding, the intersection point is returned in the out parameter. Otherwise null.
    /// </summary>
    /// <param name="polygon"></param>
    /// <param name="otherPolygon"></param>
    /// <param name="intersection"></param>
    /// <returns></returns>
    public static bool IsColliding(this Polygon2D polygon, Polygon2D otherPolygon, out Vector2? intersection)
    {
        intersection = polygon.GetIntersection(otherPolygon);
        return intersection != null;
    }

    /// <summary>
    /// Returns the intersection point of two polygons if they are colliding, otherwise null.
    /// </summary>
    /// <param name="polygon"></param>
    /// <param name="otherPolygon"></param>
    /// <returns></returns>
    public static Vector2? GetIntersection(this Polygon2D polygon, Polygon2D otherPolygon)
    {
        var thisEdges = polygon.GetEdges();
        var otherEdges = otherPolygon.GetEdges();

        foreach (var edge1 in thisEdges)
        {
            foreach (var edge2 in otherEdges)
            {
                if (edge1.Intersect(edge2, out var intersection) && intersection != null)
                {
                    return intersection.Value;
                }
            }
        }

        return null;
    }

    public static Polygon2D ToPolygon(this IEnumerable<Vector2> vertices) => new(vertices.ToArray());
    public static Polygon3D ToPolygon(this IEnumerable<Vector3> vertices) => new(vertices.ToArray());
}