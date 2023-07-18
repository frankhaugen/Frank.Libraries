using Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Physics;

public class RayCaster
{
    public RayCastResult? Cast(Ray ray, GameObjectCollection gameObjects)
    {
        var closest = float.MaxValue;
        RayCastResult? result = null;
        foreach (var gameObject in gameObjects)
        {
            var bounds = gameObject.GetBounds();
            // var intersects = Intersects(bounds, ray);
        }

        return result;
    }

    private static bool Intersects(Rectangle first, ref Rectangle second)
    {
        var distance = first.Center - second.Center;
        var radii = first.Size.ToVector2() / 2 + second.Size.ToVector2() / 2;
        return Math.Abs(distance.X) <= radii.X && Math.Abs(distance.Y) <= radii.Y;
    }
}