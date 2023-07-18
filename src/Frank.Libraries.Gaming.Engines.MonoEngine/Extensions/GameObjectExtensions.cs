using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;

public static class GameObjectExtensions
{
    public static void MoveUp(this GameObject gameObject, float speed) => gameObject.Move(Vector2.UnitY, speed);

    public static void MoveDown(this GameObject gameObject, float speed) => gameObject.Move(-Vector2.UnitY, speed);

    public static void MoveLeft(this GameObject gameObject, float speed) => gameObject.Move(-Vector2.UnitX, speed);

    public static void MoveRight(this GameObject gameObject, float speed) => gameObject.Move(Vector2.UnitX, speed);

    public static void Move(this GameObject gameObject, Vector2 direction, float speed) => gameObject.Transform.Position += (direction * speed);

    public static void SetPosition(this GameObject gameObject, Vector2 position) => gameObject.Transform.Position = position;

    public static Vector2 GetPosition(this GameObject gameObject) => gameObject.Transform.Position;

    public static bool CollidesWith(this GameObject gameObject, GameObjectCollection gameObjects)
    {
        return false;
    }

    public static bool CheckOutOfBoundsness(this GameObject gameObject)
    {
        var bounds = gameObject.GetBounds();

        var top = bounds.Top;
        var bottom = bounds.Bottom;
        var left = bounds.Left;
        var right = bounds.Right;

        var worldTop = WorldState.PlayArea.Top;
        var worldBottom = WorldState.PlayArea.Bottom;
        var worldLeft = WorldState.PlayArea.Left;
        var worldRight = WorldState.PlayArea.Right;

        if (top < worldTop)
        {
            return true;
        }

        if (bottom > worldBottom)
        {
            return true;
        }

        if (left < worldLeft)
        {
            return true;
        }

        if (right > worldRight)
        {
            return true;
        }

        return false;
    }

    public static Direction? OutOfBoundsDirection(this GameObject gameObject)
    {
        var bounds = gameObject.GetBounds();

        var top = bounds.Top;
        var bottom = bounds.Bottom;
        var left = bounds.Left;
        var right = bounds.Right;

        var worldTop = WorldState.PlayArea.Top;
        var worldBottom = WorldState.PlayArea.Bottom;
        var worldLeft = WorldState.PlayArea.Left;
        var worldRight = WorldState.PlayArea.Right;

        if (top < worldTop)
        {
            return Direction.Up;
        }

        if (bottom > worldBottom)
        {
            return Direction.Down;
        }

        if (left < worldLeft)
        {
            return Direction.Left;
        }

        if (right > worldRight)
        {
            return Direction.Right;
        }

        return null;
    }

    public static void Bounce(this GameObject gameObject)
    {
        // Check the boundary and set the normal accordingly
        Vector2 normal;
        if (gameObject.Transform.Position.X < 0 || gameObject.Transform.Position.X > WorldState.Bounds.Width)
        {
            normal = new Vector2(1, 0); // vertical boundary, normal is horizontal
        }
        else if (gameObject.Transform.Position.Y < 0 || gameObject.Transform.Position.Y > WorldState.Bounds.Height)
        {
            normal = new Vector2(0, 1); // horizontal boundary, normal is vertical
        }
        else
        {
            normal = Vector2.Zero;
            // normal = gameObject.GetBounds().GetCenter();
        }

        // Reflect the velocity
        gameObject.PhysicalProperties.Velocity = Vector2.Reflect(gameObject.PhysicalProperties.Velocity, normal);

        // Move back to the boundary.
        if (gameObject.Transform.Position.X < 0)
            gameObject.Transform.Position = new Vector2(0, gameObject.Transform.Position.Y);
        else if (gameObject.Transform.Position.X > WorldState.Bounds.Width)
            gameObject.Transform.Position = new Vector2(WorldState.Bounds.Width, gameObject.Transform.Position.Y);

        if (gameObject.Transform.Position.Y < 0)
            gameObject.Transform.Position = new Vector2(gameObject.Transform.Position.X, 0);
        else if (gameObject.Transform.Position.Y > WorldState.Bounds.Height)
            gameObject.Transform.Position = new Vector2(gameObject.Transform.Position.X, WorldState.Bounds.Height);
    }


    public static void Bounce(this GameObject gameObject, GameObject other)
    {
        var normal = gameObject.Transform.Position - other.Transform.Position;
        normal.Normalize();

        gameObject.PhysicalProperties.Velocity = Vector2.Reflect(gameObject.PhysicalProperties.Velocity, normal);
    }

    public static bool Intersects(this GameObject gameObject, GameObject other)
    {
        var bounds = gameObject.GetBounds();
        var otherBounds = other.GetBounds();

        return bounds.Intersects(otherBounds);
    }

    public static Rectangle GetBounds(this GameObject gameObject)
    {
        var size = gameObject.Shape.Size;
        var position = gameObject.Transform.Position;
        return new Rectangle(
            (int)position.X - (size.Width / 2),
            (int)position.Y - (size.Height / 2),
            size.Width,
            size.Height);
    }
}