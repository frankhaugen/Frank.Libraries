using Frank.Libraries.Gaming.Primitives;
using OpenTK.Windowing.Desktop;

namespace Frank.Libraries.Gaming.Rendering.OpenTk;

public class OpenTkRendererV3 : IRenderer, IDisposable
{
    private readonly GameWindow _gameWindow = new(GameWindowSettings.Default, NativeWindowSettings.Default);

    public void Render(Scene scene) => throw new NotImplementedException();

    public void Render(Scene scene, Action<string> callback) => throw new NotImplementedException();

    public void Dispose() => _gameWindow.Dispose();
}