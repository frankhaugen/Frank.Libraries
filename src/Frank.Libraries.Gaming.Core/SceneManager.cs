using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Core;

public class SceneManager
{
    public List<Scene> MenuScenes { get; } = new();
    public List<Scene> GameScenes { get; } = new();

    public Scene? CurrentScene { get; private set; }

    public void SelectScene(Guid id)
    {
        CurrentScene = MenuScenes.FirstOrDefault(x => x.Id == id) ?? GameScenes.FirstOrDefault(x => x.Id == id);
    }
}

public enum SceneType
{
    Menu,
    Game
}