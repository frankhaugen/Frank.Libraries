using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Rendering;

public interface IRenderer
{
    void Draw(GameObject gameObject);

    void Draw(TextBox textBox);
}