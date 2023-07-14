using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Ai;

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
        if (targetPosition.Y > paddlePosition.Y)
            _paddle.MoveUp(Speed);
        else if (targetPosition.Y < paddlePosition.Y)
            _paddle.MoveDown(Speed);
    }
}