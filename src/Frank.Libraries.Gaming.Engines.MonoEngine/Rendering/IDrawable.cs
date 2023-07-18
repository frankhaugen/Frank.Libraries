using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Rendering;

public interface IDrawable
{
    void Draw(IGraphicsDeviceContext graphicsDeviceContext, GameTime gameTime);
}