using System.Drawing;

namespace Frank.Libraries.Gaming.Primitives;

public static class ShapeFactory
{
    public static Shape CreateSpere(Color color, float radius = 10f, int resolution = 16)
    {
        var shape = new Shape
        {
            Color = color,
            Polygon = PolygonFactory.CreateSphere(radius, resolution)
        };
        return shape;
    }

    public static Shape CreateCube(Color color, float size = 10f)
    {
        var shape = new Shape
        {
            Color = color,
            Polygon = PolygonFactory.CreateCube(size)
        };
        return shape;
    }

    public static Shape CreateCylinder(Color color, float radius = 10f, float height = 10f, int resolution = 16)
    {
        var shape = new Shape
        {
            Color = color,
            Polygon = PolygonFactory.CreateCylinder(radius, height, resolution)
        };
        return shape;
    }

    public static Shape CreateCone(Color color, float radius = 10f, float height = 10f, int resolution = 16)
    {
        var shape = new Shape
        {
            Color = color,
            Polygon = PolygonFactory.CreateCone(radius, height, resolution)
        };
        return shape;
    }

    public static Shape CreatePyramid(Color color, float radius = 10f, float height = 10f)
    {
        var shape = new Shape
        {
            Color = color,
            Polygon = PolygonFactory.CreatePyramid(radius, height)
        };
        return shape;
    }
}