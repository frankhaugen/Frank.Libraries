using System.Drawing;

namespace Frank.Libraries.Gaming.Primitives;

public class Scene
{
    public Scene(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public string Name { get; }

    public Guid Id { get; }

    public Color BackgroundColor { get; set; }

    public List<GameObject> GameObjects { get; } = new();

    public Rectangle SceneSize { get; set; }

    public Camera Camera { get; set; }
}