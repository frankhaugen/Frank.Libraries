using Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Ai;

public class PongAi
{
    private readonly GameObject _paddle;
    private readonly GameObject _target;

    public PongAi(GameObject paddle, GameObject target)
    {
        _paddle = paddle;
        _target = target;
    }

    public float Speed { get; set; } = WorldState.PaddleSpeed;

    public void Update()
    {
        var targetPosition = _target.GetPosition();
        var paddlePosition = _paddle.GetPosition();
        MovePaddle(targetPosition, paddlePosition);
    }

    private void MovePaddle(Vector2 targetPosition, Vector2 paddlePosition)
    {
        var tolerance = 5;
        var heightDifference = Distance(new Vector3(0,targetPosition.Y,0), new Vector3(0, paddlePosition.Y,0));
        if (targetPosition.Y > paddlePosition.Y && heightDifference > tolerance)
            _paddle.MoveUp(Speed);
        else if (targetPosition.Y < paddlePosition.Y && heightDifference > tolerance)
            _paddle.MoveDown(Speed);
    }

    private static float Distance(Vector3 pointA, Vector3 pointB)
    {
        return (float)Math.Sqrt(Math.Pow((pointB.X - pointA.X), 2)
                                + Math.Pow((pointB.Y - pointA.Y), 2)
                                + Math.Pow((pointB.Z - pointA.Z), 2));
    }
}