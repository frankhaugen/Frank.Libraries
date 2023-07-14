using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Helper;

public static class Vector2Helper
{
    public static Vector2 Up() => new(0, -1);
    public static Vector2 Down() => new(0, 1);
    public static Vector2 Left() => new(-1, 0);
    public static Vector2 Right() => new(1, 0);
    public static Vector2 Zero() => new(0, 0);
    public static Vector2 One() => new(1, 1);

    public static Vector2 One(Direction direction) => direction switch
    {
        Direction.Up    => Up(),
        Direction.Down  => Down(),
        Direction.Left  => Left(),
        Direction.Right => Right(),
        _               => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
    };

    public static Vector2 Half() => new(0.5f, 0.5f);
    public static Vector2 Quarter() => new(0.25f, 0.25f);
    public static Vector2 ThreeQuarters() => new(0.75f, 0.75f);
}