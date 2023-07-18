using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Rendering.MonoGame;

public class GraphicsDeviceContext : IGraphicsDeviceContext
{
    private readonly GraphicsDeviceManager _graphicsDeviceManager;

    public GraphicsDeviceContext(GraphicsDeviceManager graphicsDeviceManager)
    {
        _graphicsDeviceManager = graphicsDeviceManager;
    }

    public bool IsInitialized { get; private set; }

    public GraphicsDevice GraphicsDevice => _graphicsDeviceManager.GraphicsDevice;

    public void Initialize()
    {
        // _graphicsDeviceManager.PreferredBackBufferWidth = WorldState.Bounds.Width;
        // _graphicsDeviceManager.PreferredBackBufferHeight = WorldState.Bounds.Height;
        _graphicsDeviceManager.ApplyChanges();

        IsInitialized = true;
    }

    public void SetResolution(int width, int height)
    {
        _graphicsDeviceManager.PreferredBackBufferWidth = width;
        _graphicsDeviceManager.PreferredBackBufferHeight = height;
        _graphicsDeviceManager.ApplyChanges();
    }

    public void SetFullscreen(bool fullscreen)
    {
        _graphicsDeviceManager.IsFullScreen = fullscreen;
        _graphicsDeviceManager.ApplyChanges();
    }

    public void SetVSync(bool vsync)
    {
        _graphicsDeviceManager.SynchronizeWithVerticalRetrace = vsync;
        _graphicsDeviceManager.ApplyChanges();
    }
}