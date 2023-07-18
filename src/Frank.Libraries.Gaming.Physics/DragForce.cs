using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Physics;

public class DragForce : IForce
{
    public Vector3? Calculate(GameObject gameObject, TimeSpan deltaTime)
    {
        var drag = new Vector3(0, 0, 0);
        return drag;
    }
}