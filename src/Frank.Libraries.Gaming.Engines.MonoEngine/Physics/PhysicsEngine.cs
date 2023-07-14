using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Physics;

public class PhysicsEngine : IPhysicsEngine
{
    private GameTime? _previousGameTime;

    public void Update(GameObjectCollection gameObjects, GameTime gameTime)
    {
        _previousGameTime ??= gameTime;

        var timeDifference = gameTime.ElapsedGameTime.Milliseconds - _previousGameTime.ElapsedGameTime.Milliseconds;

        if (timeDifference > WorldState.PysicsSpeed)
        {
            for (var i = 0; i < timeDifference; i++)
            {
                UpdateAll(gameObjects, _previousGameTime);
            }
        }
        else
        {
            UpdateAll(gameObjects, gameTime);
        }

        _previousGameTime = gameTime;
    }

    private static void UpdateAll(GameObjectCollection gameObjects, GameTime gameTime)
    {
        foreach (var currentGameObject in gameObjects)
        {
            if (currentGameObject.PhysicalProperties.IsStatic)
                continue;

            HandleOutOfBoundsIfAny(currentGameObject);
            HandleGameObjectCollisions(gameObjects, currentGameObject);

            currentGameObject.Transform.Position += currentGameObject.PhysicalProperties.Velocity * gameTime.ElapsedGameTime.Milliseconds;
        }
    }

    private static void HandleOutOfBoundsIfAny(GameObject currentGameObject)
    {
        if (!currentGameObject.CheckOutOfBoundsness())
        {
            // step forward to next "frame" and check again
            currentGameObject.Transform.Position += currentGameObject.PhysicalProperties.Velocity;
            if (!currentGameObject.CheckOutOfBoundsness())
            {
                currentGameObject.Transform.Position -= currentGameObject.PhysicalProperties.Velocity;
                return;
            }
        }

        BounceOrFlipVelocity(currentGameObject);
    }

    private static void HandleGameObjectCollisions(GameObjectCollection gameObjects, GameObject currentGameObject)
    {
        foreach (var otherGameObject in gameObjects.Where(x => x != currentGameObject && x.PhysicalProperties.IsCollider))
        {
            if (!currentGameObject.Intersects(otherGameObject))
            {
                // step forward to next "frame" and check again
                currentGameObject.Transform.Position += currentGameObject.PhysicalProperties.Velocity;
                if (!currentGameObject.Intersects(otherGameObject))
                {
                    currentGameObject.Transform.Position -= currentGameObject.PhysicalProperties.Velocity;
                    continue;
                }
                currentGameObject.Transform.Position -= currentGameObject.PhysicalProperties.Velocity;
            }

            BounceOrStop(currentGameObject, otherGameObject);
            break;
        }
    }

    private static void BounceOrFlipVelocity(GameObject currentGameObject)
    {
        if (currentGameObject.PhysicalProperties.IsBouncy)
            currentGameObject.Bounce();
        else
            currentGameObject.PhysicalProperties.Velocity = -currentGameObject.PhysicalProperties.Velocity;
    }

    private static void BounceOrStop(GameObject currentGameObject, GameObject otherGameObject)
    {
        if (currentGameObject.PhysicalProperties.IsBouncy)
            currentGameObject.Bounce(otherGameObject);
        else
            currentGameObject.PhysicalProperties.Velocity = Vector2.Zero;
    }
}