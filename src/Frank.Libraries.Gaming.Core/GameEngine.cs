using Frank.Libraries.Gaming.Primitives;
using Frank.Libraries.Gaming.Rendering;

namespace Frank.Libraries.Gaming.Core;

public class GameEngine
{
    private IRenderer _renderer;

    public bool IsInitialized { get; private set; } = false;

    public SceneManager SceneManager { get; } = new();

    public Scene? CurrentScene => SceneManager.CurrentScene;

    public void Initialize(IRenderer renderer)
    {
        if (CurrentScene is null)
            throw new Exception("No scene has been set.");

        _renderer = renderer;

        IsInitialized = true;
    }

    public void Update(UpdateArgs args)
    {

    }

    public void Draw()
    {
        if (CurrentScene is null)
            return;
        _renderer.Render(CurrentScene);
    }
}

public readonly record struct UpdateArgs(TimeSpan ElapsedTime, TimeSpan TotalTime);