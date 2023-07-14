using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class Edge2DExtensions
{
    public static bool Intersect(this Edge2D edge, Edge2D other, out Vector2? intersectionPoint)
    {
        // Calculate the intersection point of two line segments
        float x1 = edge.A.X, y1 = edge.A.Y, x2 = edge.B.X, y2 = edge.B.Y;
        float x3 = other.A.X, y3 = other.A.Y, x4 = other.B.X, y4 = other.B.Y;

        var denominator = (y4 - y3) * (x2 - x1) - (x4 - x3) * (y2 - y1);
        if (denominator == 0)
        {
            // The lines are parallel or coincident
            intersectionPoint = null;
            return false;
        }

        var ua = ((x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3)) / denominator;
        var ub = ((x2 - x1) * (y1 - y3) - (y2 - y1) * (x1 - x3)) / denominator;

        if (ua < 0 || ua > 1 || ub < 0 || ub > 1)
        {
            // The intersection point is outside the line segments
            intersectionPoint = null;
            return false;
        }

        var x = x1 + ua * (x2 - x1);
        var y = y1 + ua * (y2 - y1);
        intersectionPoint = new Vector2(x, y);
        return true;
    }
}