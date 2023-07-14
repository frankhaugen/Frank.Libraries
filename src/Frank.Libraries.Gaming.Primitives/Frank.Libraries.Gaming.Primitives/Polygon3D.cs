using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Polygon3D : Polygon<Vector3>
{
    public Polygon3D(params Vector3[] vertices) : base(vertices)
    {
    }
}