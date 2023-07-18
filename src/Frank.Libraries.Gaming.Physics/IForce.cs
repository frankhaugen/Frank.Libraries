using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Physics;

public interface IForce
{
    /// <summary>
    /// Calculates the force (velocity change) to apply to something
    /// </summary>
    /// <param name="gameObject"></param>
    /// <param name="deltaTime"></param>
    /// <returns></returns>
    public Vector3? Calculate(GameObject gameObject, TimeSpan deltaTime);
}