using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Rendering;

public interface IRenderer
{
    void Render(Scene scene);

    void Render(Scene scene, Action<string> callback);
}