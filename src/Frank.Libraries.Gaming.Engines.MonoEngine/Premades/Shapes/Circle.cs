using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades.Shapes;

public class Circle : Shape
{
    public Circle(float radius, Color color, int sides = 32)
    {
        Polygon = CreateCirclePolygon(radius, sides);
        Color = color;
        Size = new Size((int)radius * 2, (int)radius * 2);
    }

    private static Polygon CreateCirclePolygon(float radius, int sides)
    {
        var vertices = new List<Vector2>();
        var step = MathHelper.TwoPi / sides;
        for (var theta = 0f; theta < MathHelper.TwoPi; theta += step)
        {
            var x = radius * MathF.Cos(theta);
            var y = radius * MathF.Sin(theta);
            vertices.Add(new Vector2(x, y));
        }

        var polygon = new Polygon(vertices.ToArray());

        polygon = polygon.Translate(Vector2.Zero);

        return polygon;
    }
}