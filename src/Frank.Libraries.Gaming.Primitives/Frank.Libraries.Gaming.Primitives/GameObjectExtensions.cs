namespace Frank.Libraries.Gaming.Primitives;

public static class GameObjectExtensions
{
    public static Shape GetTransformedShape(this GameObject gameObject)
    {
        var shape = gameObject.Shape;
        var transform = gameObject.Transform;
        var transformedShape = shape.GetTransformedShape(transform);
        return transformedShape;
    }
}