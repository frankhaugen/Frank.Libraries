using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Collisions;

public class GameObjectCollider
{
    private readonly GameObject _gameObject;
    private readonly GameObjectCollection _gameObjects;

    public GameObjectCollider(GameObject gameObject, GameObjectCollection gameObjects)
    {
        _gameObject = gameObject;
        _gameObjects = gameObjects;
    }

    public bool IsColliding(out IEnumerable<KeyValuePair<GameObject, Direction>>? collision)
    {
        var bounds = _gameObject.GetBounds();

        var collisions = new List<KeyValuePair<GameObject, Direction>>();
        foreach (var gameObject in _gameObjects.Where(x => x is { IsActive: true, PhysicalProperties.IsCollider: true }))
        {
            if (gameObject == _gameObject) continue;
            var otherBounds = gameObject.GetBounds();
            if (bounds.Intersects(otherBounds))
            {
                var distanceDirection = GetDirection(bounds, otherBounds);
                if (distanceDirection != null)
                {
                    collisions.Add(new KeyValuePair<GameObject, Direction>(gameObject, distanceDirection.Value.Direction));
                }
            }
        }

        if (collisions.Any())
        {
            collision = collisions;
            return true;
        }

        collision = null;
        return false;
    }

    private DistanceDirection? GetDirection(Rectangle bounds, Rectangle otherBounds)
    {
        var left = bounds.Left - otherBounds.Right;
        var right = bounds.Right - otherBounds.Left;
        var top = bounds.Top - otherBounds.Bottom;
        var bottom = bounds.Bottom - otherBounds.Top;

        var min = new[] { left, right, top, bottom }.Min();

        if (min == left) return new DistanceDirection(left, Direction.Left);
        if (min == right) return new DistanceDirection(right, Direction.Right);
        if (min == top) return new DistanceDirection(top, Direction.Up);
        if (min == bottom) return new DistanceDirection(bottom, Direction.Down);

        return null;
    }
}

public readonly record struct DistanceDirection(float Distance, Direction Direction);