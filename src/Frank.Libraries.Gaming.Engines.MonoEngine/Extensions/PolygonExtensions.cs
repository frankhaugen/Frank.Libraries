using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class PolygonExtensions
{
    public static VertexPositionColor[] ToVertexPositionColors(this Polygon polygon, Color color)
    {
        var edges = polygon.GetEdges();
        var lines = edges.ToVertexPositionColors(color);
        return lines;
    }

    public static Rectangle GetBoundsX(this Polygon polygon)
    {
        var minX = GetRightmostPoint(polygon)
            .ToInt();
        var minY = GetLowestPoint(polygon)
            .ToInt();
        var maxX = GetLeftmostPoint(polygon)
            .ToInt();
        var maxY = GetHighestPoint(polygon)
            .ToInt();


        return new Rectangle(minX, minY, maxX - minX, maxY - minY);
    }

    public static float GetLowestPoint(this Polygon polygon) => polygon.Min(x => x.X);

    public static float GetHighestPoint(this Polygon polygon) => polygon.Max(x => x.X);

    public static float GetLeftmostPoint(this Polygon polygon) => polygon.Min(x => x.Y);

    public static float GetRightmostPoint(this Polygon polygon) => polygon.Max(x => x.Y);

        public static Polygon Scale(this Polygon polygon, float scale)
    {
        var vertices = new Vector2[polygon.Length];
        for (var i = 0; i < polygon.Length; i++) vertices[i] = polygon[i] * scale;
        return new Polygon(vertices);
    }

    public static Polygon Translate(this Polygon _polygon, Vector2 translation)
    {
        var vertices = new Vector2[_polygon.Length];
        for (var i = 0; i < _polygon.Length; i++) vertices[i] = _polygon[i] + translation;
        return new Polygon(vertices);
    }

    public static Polygon Rotate(this Polygon _polygon, float angle)
    {
        var vertices = new Vector2[_polygon.Length];
        for (var i = 0; i < _polygon.Length; i++) vertices[i] = Vector2.Transform(_polygon[i], Matrix.CreateRotationZ(angle));
        return new Polygon(vertices);
    }

    public static float Area(this Polygon _polygon)
    {
        var area = 0f;
        var j = _polygon.Length - 1;

        for (var i = 0; i < _polygon.Length; i++)
        {
            area += (_polygon[j].X + _polygon[i].X) * (_polygon[j].Y - _polygon[i].Y);
            j = i;
        }

        return Math.Abs(area / 2f);
    }

    public static float Perimeter(this Polygon _polygon)
    {
        var perimeter = 0f;
        var j = _polygon.Length - 1;

        for (var i = 0; i < _polygon.Length; i++)
        {
            perimeter += Vector2.Distance(_polygon[j], _polygon[i]);
            j = i;
        }

        return perimeter;
    }

    public static float[] ToVertexArray(this Polygon _polygon)
    {
        var array = new float[_polygon.Length * 2];
        for (var i = 0; i < _polygon.Length; i++)
        {
            var vertex = _polygon[i];
            array[i * 2] = vertex.X;
            array[i * 2 + 1] = vertex.Y;
        }

        return array;
    }

    public static Edge[] GetEdges(this Polygon _polygon)
    {
        var edges = new Edge[_polygon.Length];
        for (var i = 0; i < _polygon.Length; i++)
        {
            edges[i] = new Edge(_polygon[i], _polygon[(i + 1) % _polygon.Length]);
        }

        return edges;
    }
}