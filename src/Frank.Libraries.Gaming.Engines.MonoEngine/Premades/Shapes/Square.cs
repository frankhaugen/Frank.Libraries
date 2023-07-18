using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Premades.Shapes;

public class Square : Shape
{
    public Square(float width, float height, Color color)
    {
        Polygon = CreateSquarePolygon(width, height);
        Color = color;
        Size = new Size((int)width, (int)height);
    }

    private static Polygon CreateSquarePolygon(float width, float height)
    {
        var halfWidth = width / 2;
        var halfHeight = height / 2;

        var vertices = new List<Vector2>
        {
            new Vector2(-halfWidth, -halfHeight),
            new Vector2(halfWidth, -halfHeight),
            new Vector2(halfWidth, halfHeight),
            new Vector2(-halfWidth, halfHeight),
            new Vector2(-halfWidth, -halfHeight)
        };
        var polygon = new Polygon(vertices.ToArray());
        return polygon;
    }
}