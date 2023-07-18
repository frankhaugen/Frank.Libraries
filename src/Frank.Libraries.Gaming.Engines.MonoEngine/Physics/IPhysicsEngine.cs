using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Physics;

public interface IPhysicsEngine
{
    void Update(GameObjectCollection gameObjects, GameTime gameTime);
}