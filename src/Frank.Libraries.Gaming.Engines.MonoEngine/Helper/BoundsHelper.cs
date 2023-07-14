using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Helper;

public static class BoundsHelper
{
    public static bool IsOutOfBounds(GameObject bounds, GameObject other)
    {
        return !bounds.Intersects(other);
    }
}