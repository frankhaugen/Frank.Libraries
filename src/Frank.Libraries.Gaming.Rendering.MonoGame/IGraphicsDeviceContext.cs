using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Rendering.MonoGame;

public interface IGraphicsDeviceContext
{
    bool IsInitialized { get; }

    GraphicsDevice GraphicsDevice { get; }

    void Initialize();

    void SetResolution(int width, int height);

    void SetFullscreen(bool fullscreen);

    void SetVSync(bool vsync);
}