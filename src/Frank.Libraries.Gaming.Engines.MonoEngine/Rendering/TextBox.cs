using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Rendering;

public class TextBox
{
    public string Text { get; set; } = string.Empty;
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Color Color { get; set; } = Color.White;
    public float Scale { get; set; } = 1f;
    public float Rotation { get; set; } = 0f;
    public bool ShowBorder { get; set; } = false;
}