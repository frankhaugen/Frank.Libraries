using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Rendering;

public interface IRenderer
{
    void Draw(GameObject gameObject);

    void Draw(TextBox textBox);
}