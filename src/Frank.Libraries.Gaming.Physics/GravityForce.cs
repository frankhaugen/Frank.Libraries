using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Physics;

public class GravityForce : IForce
{
    public Vector3? Calculate(GameObject gameObject, TimeSpan deltaTime)
    {
        var gravity = new Vector3(0, Constants.TerrestrialConstants.EarthGravity, 0) * deltaTime.Seconds;
        return gravity;
    }
}