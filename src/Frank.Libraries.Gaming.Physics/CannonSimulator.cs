using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Physics;

public class CannonSimulator
{
    private readonly Vector3 _initialVelocity;
    private readonly Vector3 _gravity;

    public CannonSimulator(double gramsOfGunpowder, float mass, Vector3 launchDirection, Vector3 gravity)
    {
        _gravity = gravity;
        var initialForce = gramsOfGunpowder * Constants.PhysicsConstants.GunpowderEnergyPerGramInJoules; // Convert grams to joules (energy)
        _initialVelocity = ForceHelper.GetInitialVelocity(initialForce, mass, launchDirection);
    }

    public Vector3 GetPosition(TimeSpan time)
    {
        float t = (float)time.TotalSeconds;
        // We need to update all three components x, y and z
        float x = _initialVelocity.X * t;
        float y = _initialVelocity.Y * t - 0.5f * _gravity.Y * t * t;
        float z = _initialVelocity.Z * t - 0.5f * _gravity.Z * t * t;

        return new Vector3(x, y, z);
    }
}