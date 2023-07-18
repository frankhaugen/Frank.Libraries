using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;

public static partial class GraphicsDeviceExtensions
{
    public static void Draw(this GraphicsDevice graphicsDevice, GameObject gameObject)
    {
        var position = gameObject.Transform.Position;
        var scale = gameObject.Transform.Scale;
        var rotation = gameObject.Transform.Rotation;

        var polygon = gameObject.Shape.Polygon;
        var color = gameObject.Shape.Color;

        polygon = polygon.Scale(scale)
                         .Rotate(QuaternionConverter.ToAngle(rotation))
                         .Translate(position);

        graphicsDevice.Draw(polygon, color, PrimitiveType.LineList);
    }

    public static void Draw(this GraphicsDevice graphicsDevice, Polygon polygon, Color color, PrimitiveType primitiveType)
    {
        switch (primitiveType)
        {
            case PrimitiveType.LineList:
                graphicsDevice.DrawLineList(polygon, color);
                break;
            case PrimitiveType.LineStrip:
                graphicsDevice.DrawLineStrip(polygon, color);
                break;
            case PrimitiveType.PointList:
                graphicsDevice.DrawPointList(polygon, color);
                break;
            case PrimitiveType.TriangleList:
                graphicsDevice.DrawTriangleList(polygon, color);
                break;
            case PrimitiveType.TriangleStrip:
                graphicsDevice.DrawTriangleStrip(polygon, color);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(primitiveType), primitiveType, null);
        }
    }

    public static void DrawLineList(this GraphicsDevice graphicsDevice, Polygon polygon, Color color)
    {
        var edges = polygon.GetEdges();
        var lineList = new VertexPositionColor[edges.Length * 2];
        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];
            lineList[i * 2] = new VertexPositionColor(new Vector3(edge.Start.X, edge.Start.Y, 0), color);
            lineList[i * 2 + 1] = new VertexPositionColor(new Vector3(edge.End.X, edge.End.Y, 0), color);
        }

        graphicsDevice.DrawUserPrimitives(PrimitiveType.LineList, lineList, 0, lineList.Length / PrimitiveType.LineList.GetVertexCount());
    }

    public static void DrawPointList(this GraphicsDevice graphicsDevice, Polygon polygon, Color color)
    {
        var pointList = polygon.ToVertexPositionColors(color);
        graphicsDevice.DrawUserPrimitives(PrimitiveType.PointList, pointList, 0, pointList.Length / PrimitiveType.PointList.GetVertexCount());
    }

    public static void DrawTriangleList(this GraphicsDevice graphicsDevice, Polygon polygon, Color color)
    {
        var triangleList = polygon.ToVertexPositionColors(color);
        graphicsDevice.DrawUserPrimitives(PrimitiveType.TriangleList, triangleList, 0, triangleList.Length / PrimitiveType.TriangleList.GetVertexCount());
    }

    public static void DrawTriangleStrip(this GraphicsDevice graphicsDevice, Polygon polygon, Color color)
    {
        var triangleStrip = polygon.ToVertexPositionColors(color);
        graphicsDevice.DrawUserPrimitives(PrimitiveType.TriangleStrip, triangleStrip, 0, triangleStrip.Length / PrimitiveType.TriangleStrip.GetVertexCount());
    }

    public static void DrawLineStrip(this GraphicsDevice graphicsDevice, Polygon polygon, Color color)
    {
        var lineStrip = polygon.ToVertexPositionColors(color);
        graphicsDevice.DrawUserPrimitives(PrimitiveType.LineStrip, lineStrip, 0, lineStrip.Length / PrimitiveType.LineStrip.GetVertexCount());
    }
}