using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Rendering.Console;

public class ConsoleRenderer : IRenderer
{
    private readonly Viewport _viewport;

    public ConsoleRenderer(int width, float aspectRatio)
    {
        var height = (int)(width / aspectRatio);
        _viewport = new Viewport(new Vector3(width, height, 0));
    }

    public void Render(Scene scene) => throw new NotImplementedException();

    public void Render(Scene scene, Action<string> callback)
    {
        var polygons = scene.GetTransformedShapes().Select(x => x.Polygon);
        var consoleImage = Render(polygons);
        callback(consoleImage);
    }

    private string Render(IEnumerable<Polygon> polygons)
    {
        _viewport.Clear();

        foreach (var polygon in polygons)
        {
            foreach (var vertex in polygon)
            {
                _viewport.SetPixel(vertex, "#");
            }
        }

        return _viewport.ToString();
    }
}