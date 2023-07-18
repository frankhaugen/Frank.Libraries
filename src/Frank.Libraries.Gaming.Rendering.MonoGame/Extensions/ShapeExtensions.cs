using Frank.Libraries.Gaming.Primitives;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Rendering.MonoGame.Extensions;

public static class ShapeExtensions
{
    public static VertexPositionColor[] ToVertexPositionColors(this Shape shape, System.Drawing.Color color)
    {
        var polygon = shape.Polygon;
        var edges = polygon.Edges;
        var lines = edges.ToVertexPositionColors(color);
        return lines;
    }
}