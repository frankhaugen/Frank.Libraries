using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Collisions;

public interface IRaycastable
{
    bool Raycast(Vector2 origin, Vector2 direction, float maxDistance, out Vector2 point);
}