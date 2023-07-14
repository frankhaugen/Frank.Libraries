using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Polygon2D : Polygon<Vector2>
{
    public Polygon2D(params Vector2[] vertices) : base(vertices)
    {
    }

}

