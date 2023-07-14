using Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades.Shapes;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;

public class Shape
{
    public Polygon Polygon { get; set; } = new(Array.Empty<Vector2>());
    public Color Color { get; set; } = Color.White;
    public Size Size { get; set; } = new(0, 0);
}