using Frank.Libraries.Gaming.Primitives;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Rendering.MonoGame.Extensions;

public static class PolygonExtensions
{
    public static VertexPositionColor[] ToVertexPositionColors(this Polygon polygon, System.Drawing.Color color)
    {
        var edges = polygon.Edges;
        var lines = edges.ToVertexPositionColors(color);
        return lines;
    }
}