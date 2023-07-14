using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Physics;

public interface IPhysicsEngine
{
    void Update(GameObjectCollection gameObjects, GameTime gameTime);
}