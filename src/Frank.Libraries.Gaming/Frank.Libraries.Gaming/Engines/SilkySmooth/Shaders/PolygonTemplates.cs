using System.Drawing;
using Frank.Libraries.Gaming.Engines.SilkySmooth.Types;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Shaders;

public static class PolygonTemplates
{
    // Create a polygon that represents a square.
    public static unsafe Polygon2D Square(Vertex2D center, float edgeLength, Color color)
    {
        var halfLength = edgeLength / 2;

        var vertices = stackalloc Vertex2DColor[4]
        {
            new Vertex2DColor(center.X - halfLength, center.Y - halfLength, color.R, color.G, color.B),
            new Vertex2DColor(center.X + halfLength, center.Y - halfLength, color.R, color.G, color.B),
            new Vertex2DColor(center.X + halfLength, center.Y + halfLength, color.R, color.G, color.B),
            new Vertex2DColor(center.X - halfLength, center.Y + halfLength, color.R, color.G, color.B),
        };

        return new Polygon2D(new Span<Vertex2DColor>(vertices, 4));
    }

    // Create a polygon that represents an equilateral triangle.
    public static unsafe Polygon2D Triangle(Vertex2D center, float edgeLength)
    {
        var halfLength = edgeLength / 2;
        var height = MathF.Sqrt(3) / 2 * edgeLength;

        var vertices = stackalloc Vertex2DColor[3]
        {
            new Vertex2DColor(center.X, center.Y + height / 2, 1f, 1f, 1f),
            new Vertex2DColor(center.X - halfLength, center.Y - height / 2, 1f, 1f, 1f),
            new Vertex2DColor(center.X + halfLength, center.Y - height / 2, 1f, 1f, 1f),
        };

        return new Polygon2D(new Span<Vertex2DColor>(vertices, 3));
    }

    // Other polygon templates...
}