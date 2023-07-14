using System.Drawing;

namespace Frank.Libraries.Gaming.Primitives;

public class Scene2D
{
    public Scene2D(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public Color BackgroundColor { get; set; }
    public List<Polygon2D> Polygons { get; set; } = new();

    public Rectangle SceneSize { get; set; }

    public Camera Camera { get; set; }
}