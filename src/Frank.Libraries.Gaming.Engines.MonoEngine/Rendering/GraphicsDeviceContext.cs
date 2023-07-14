using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Rendering;

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
        _graphicsDeviceManager.PreferredBackBufferWidth = WorldState.Bounds.Width;
        _graphicsDeviceManager.PreferredBackBufferHeight = WorldState.Bounds.Height;
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

    public void SetFixedTimeStep(bool fixedTimeStep)
    {
        _graphicsDeviceManager.SynchronizeWithVerticalRetrace = fixedTimeStep;
        _graphicsDeviceManager.ApplyChanges();
    }

    public void SetShowFps(bool showFps)
    {
        _graphicsDeviceManager.SynchronizeWithVerticalRetrace = showFps;
        _graphicsDeviceManager.ApplyChanges();
    }

    public void SetShowDebugInfo(bool showDebugInfo)
    {
        _graphicsDeviceManager.SynchronizeWithVerticalRetrace = showDebugInfo;
        _graphicsDeviceManager.ApplyChanges();
    }

    public void SetShowMouse(bool showMouse)
    {
        _graphicsDeviceManager.SynchronizeWithVerticalRetrace = showMouse;
        _graphicsDeviceManager.ApplyChanges();
    }
}