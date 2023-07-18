using System.Numerics;

namespace Frank.Libraries.Gaming.Physics;

public static class ForceHelper
{
    const double DegToRad = Math.PI / 180.0;

    public static Vector3 GetInitialVelocity(double force, float mass, Vector3 direction)
    {
        var initialSpeed = (float)(force / mass);
        direction = Vector3.Normalize(direction); // Normalize direction vector
        return direction * initialSpeed;
    }

    public static Vector3 CalculateForce(Vector3 direction, float magnitude , TimeSpan deltaTime) => direction * magnitude * deltaTime.Seconds;

    public static Vector3 ApplyForce(Vector3 vector, Vector3 force) => vector + force;

    public static Vector3 ApplyForce(Vector3 vector, Vector3 force, float mass) => vector + force / mass;

    public static Vector3 ApplyForce(Vector3 vector, Vector3 force, float mass, TimeSpan deltaTime) => vector + force / mass * deltaTime.Seconds;
}