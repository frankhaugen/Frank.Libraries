using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class PolygonFactory
{
    public static Polygon2D CreateRectangle(float width, float height)
    {
        var polygon = new Vector2[4];
        polygon[0] = new Vector2(0, 0);
        polygon[1] = new Vector2(width, 0);
        polygon[2] = new Vector2(width, height);
        polygon[3] = new Vector2(0, height);
        return polygon.ToPolygon();
    }

    public static Polygon2D CreateCircle(float radius, int sides)
    {
        var polygon = new Vector2[sides];
        var step = (float)(Math.PI * 2 / sides);
        for (var i = 0; i < sides; i++)
        {
            var angle = step * i;
            polygon[i] = new Vector2((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius);
        }
        return polygon.ToPolygon();
    }

    public static Polygon2D CreateTriangle(float width, float height)
    {
        var polygon = new Vector2[3];
        polygon[0] = new Vector2(0, 0);
        polygon[1] = new Vector2(width, 0);
        polygon[2] = new Vector2(width / 2, height);
        return polygon.ToPolygon();
    }

    public static Polygon2D CreateHexagon(float radius)
    {
        var polygon = new Vector2[6];
        const float step = (float)(Math.PI * 2 / 6);
        for (var i = 0; i < 6; i++)
        {
            var angle = step * i;
            polygon[i] = new Vector2((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius);
        }
        return polygon.ToPolygon();
    }
}