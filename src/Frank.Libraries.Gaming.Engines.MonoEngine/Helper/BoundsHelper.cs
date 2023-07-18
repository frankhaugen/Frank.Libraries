using Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Helper;

public static class BoundsHelper
{
    public static bool IsOutOfBounds(GameObject bounds, GameObject other)
    {
        return !bounds.Intersects(other);
    }
}