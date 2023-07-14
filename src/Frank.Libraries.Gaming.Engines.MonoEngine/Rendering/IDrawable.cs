using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Rendering;

public interface IDrawable
{
    void Draw(IGraphicsDeviceContext graphicsDeviceContext, GameTime gameTime);
}