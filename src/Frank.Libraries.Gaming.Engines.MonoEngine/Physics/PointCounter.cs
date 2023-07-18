using Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Physics;

public class PointCounter
{
    private DateTime _lastPointTime = DateTime.MinValue;

    public void Update(GameObjectCollection gameObjects)
    {
        if (!IsOneSecondElapsedSinceLastPoint())
            return;

        UpdateGameObjects(gameObjects);
    }

    private bool IsOneSecondElapsedSinceLastPoint()
    {
        var timeSinceLastPoint = DateTime.UtcNow - _lastPointTime;
        return timeSinceLastPoint.TotalSeconds >= 1;
    }

    private void UpdateGameObjects(GameObjectCollection gameObjects)
    {
        foreach (var gameObject in gameObjects)
        {
            UpdateGameObject(gameObject);
        }
    }

    private void UpdateGameObject(GameObject gameObject)
    {
        if (!gameObject.PhysicalProperties.IsStatic && IsBallOutOfBounds(gameObject))
        {
            _lastPointTime = DateTime.UtcNow;
            UpdateWorldState(gameObject.OutOfBoundsDirection());
        }
    }

    private static bool IsBallOutOfBounds(GameObject gameObject) => gameObject.CheckOutOfBoundsness() && gameObject.Name == "Ball";

    private static void UpdateWorldState(Direction? direction)
    {
        switch (direction)
        {
            case Direction.Left:
                WorldState.AiPoints++;
                break;
            case Direction.Right:
                WorldState.PlayerPoints++;
                break;
            case Direction.Up:
            case Direction.Down:
                break;
            case null:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }
    }
}