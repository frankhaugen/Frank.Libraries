using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class SceneExtensions
{
    public static IEnumerable<Shape> GetTransformedShapes(this Scene scene)
        => from gameObject in scene.GameObjects let shape = gameObject.Shape let transform = gameObject.Transform select shape.Transform(transform);

    public static Shape Transform(this Shape shape, Transform transform)
    {
        var transformedShape = shape;
        if (transform.Position != shape.Polygon.Position)
            transformedShape = transformedShape.Translate(transform.Position);
        if (transform.Rotation != Quaternion.Zero)
            transformedShape = transformedShape.Rotate(transform.Rotation);
        if (Math.Abs(transform.Scale - 1f) > 0.001f)
            transformedShape = transformedShape.Scale(transform.Scale);
        return transformedShape;
    }

    public static Shape Translate(this Shape shape, Vector3 position)
    {
        return new Shape()
        {
            Polygon = shape.Polygon.Translate(position),
            Color = shape.Color
        };
    }

    public static Shape Rotate(this Shape shape, Quaternion rotation)
    {
        return new Shape()
        {
            Polygon = shape.Polygon.Rotate(rotation),
            Color = shape.Color
        };
    }

    public static Shape Scale(this Shape shape, float scale)
    {
        return new Shape()
        {
            Polygon = shape.Polygon.Scale(scale),
            Color = shape.Color
        };
    }
}