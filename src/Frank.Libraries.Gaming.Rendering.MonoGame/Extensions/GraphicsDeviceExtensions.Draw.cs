using System.Drawing;
using Frank.Libraries.Gaming.Primitives;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Rendering.MonoGame.Extensions;

public static partial class GraphicsDeviceExtensions
{
    public static void Draw(this GraphicsDevice graphicsDevice, GameObject gameObject)
    {
        var shape = gameObject.Shape;
        graphicsDevice.Draw(shape);
    }

    public static void Draw(this GraphicsDevice graphicsDevice, Shape shape)
    {
        var polygon = shape.Polygon;
        var color = shape.Color;
        // graphicsDevice.DrawLineList(polygon, color);
        graphicsDevice.DrawTriangleList(polygon, color);
    }

    public static void DrawLineList(this GraphicsDevice graphicsDevice, Polygon polygon, Color color)
    {
        var lineList = polygon.ToVertexPositionColors(color);
        graphicsDevice.DrawUserPrimitives(PrimitiveType.LineList, lineList, 0, lineList.Length / PrimitiveType.LineList.GetVertexCount());
    }

    public static void DrawTriangleList(this GraphicsDevice graphicsDevice, Polygon polygon, Color color)
    {
        var faceList = FaceFactory.CreateParallel(polygon);
        var triangleList = faceList.Select(x => new VertexPositionColor(x.GetNormal(), color.ToColor())).ToArray();
        graphicsDevice.DrawUserPrimitives(PrimitiveType.TriangleList, triangleList, 0, triangleList.Length / PrimitiveType.TriangleList.GetVertexCount());
    }
}