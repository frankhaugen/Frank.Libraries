using System.Drawing;
using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Shape2D
{
    public Polygon2D Polygon { get; set; } = new(Array.Empty<Vector2>());
    public Color Color { get; set; } = Color.White;
}