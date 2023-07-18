using System.Drawing;
using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class GameObjectFactory
{
    public static GameObject CreateGameObject(Transform transform, Shape shape, string? name = null)
    {
        var gameObject = new GameObject
        {
            Name = name,
            Transform = transform,
            Shape = shape
        };
        return gameObject;
    }

    public static GameObject CreateGameObject()
    {
        var gameObject = new GameObject
        {
            Transform = TransformFactory.CreateTransform(),
            Shape = ShapeFactory.CreateSpere(Color.White)
        };
        return gameObject;
    }

}