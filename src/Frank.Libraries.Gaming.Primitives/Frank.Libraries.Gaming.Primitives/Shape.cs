using System.Drawing;
using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Shape
{
    public Polygon Polygon { get; set; } = new(Array.Empty<Vector3>());
    public Color Color { get; set; } = Color.White;

    public override string ToString() => $"{Polygon}";
}