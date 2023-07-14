using System.Drawing;
using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Shape3D
{
    public Polygon3D Polygon { get; set; } = new(Array.Empty<Vector3>());
    public Color Color { get; set; } = Color.White;
}