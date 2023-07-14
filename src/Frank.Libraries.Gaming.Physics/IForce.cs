using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Physics;

public interface IForce<in T>
{
    /// <summary>
    /// Calculates the force (velocity change) to apply to something
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public Vector3? Calculate(T obj, TimeSpan deltaTime);
}

public class GravityForce : IForce<IPhysicsObject>
{
    public Vector3? Calculate(IPhysicsObject obj, TimeSpan deltaTime)
    {
        var gravity = new Vector3(0, Constants.TerrestrialConstants.EarthGravity, 0) * deltaTime.Seconds;
        return gravity;
    }
}

public interface IPhysicsObject
{
    public float Mass { get; set; }
}