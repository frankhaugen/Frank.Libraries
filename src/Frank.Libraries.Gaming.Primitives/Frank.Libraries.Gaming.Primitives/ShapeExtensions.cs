namespace Frank.Libraries.Gaming.Primitives;

public static class ShapeExtensions
{
    public static Shape GetTransformedShape(this Shape shape, Transform transform)
    {
        var polygon = shape.Polygon;
        var transformedPolygon = polygon.Translate(transform.Position);
        var transformedShape = new Shape
        {
            Polygon = transformedPolygon,
            Color = shape.Color
        };
        return transformedShape;
    }
}