using Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Physics;

public readonly struct Ray
{
    public Vector2 Position { get; }
    public Vector2 Direction { get; }

    public Ray(Vector2 position, Vector2 direction)
    {
        Position = position;
        Direction = direction;
    }

    public bool Intersects(Rectangle boundingRectangle, out float rayNearDistance, out float rayFarDistance)
    {
        // Real-Time Collision Detection, Christer Ericson, 2005. Chapter 5.3; Basic Primitive Tests - Intersecting Lines, Rays, and (Directed Segments). pg 179-181

        var minimum = boundingRectangle.Center.ToVector2() - boundingRectangle.GetHalfExtents();
        var maximum = boundingRectangle.Center.ToVector2() + boundingRectangle.GetHalfExtents();

        // Set to the smallest possible value so the algorithm can find the first hit along the ray
        var minimumDistanceAlongRay = float.MinValue;
        // Set to the maximum possible value so the algorithm can find the last hit along the ray
        var maximumDistanceAlongRay = float.MaxValue;

        // For all relevant slabs which in this case is two.

        // The first, horizontal, slab.
        if (!IntersectsSlab(Position.X, Direction.X, minimum.X, maximum.X,
                            ref minimumDistanceAlongRay,
                            ref maximumDistanceAlongRay))
        {
            rayNearDistance = rayFarDistance = float.NaN;
            return false;
        }

        // The second, vertical, slab.
        if (!IntersectsSlab(Position.Y, Direction.Y, minimum.Y, maximum.Y,
                            ref minimumDistanceAlongRay,
                            ref maximumDistanceAlongRay))
        {
            rayNearDistance = rayFarDistance = float.NaN;
            return false;
        }

        // Ray intersects the 2 slabs.
        rayNearDistance = minimumDistanceAlongRay < 0
            ? 0
            : minimumDistanceAlongRay;
        rayFarDistance = maximumDistanceAlongRay;
        return true;
    }

    private static bool IntersectsSlab(float positionCoordinate, float directionCoordinate, float slabMinimum,
                                       float slabMaximum, ref float rayMinimumDistance, ref float rayMaximumDistance)
    {
        // Real-Time Collision Detection, Christer Ericson, 2005. Chapter 5.3; Basic Primitive Tests - Intersecting Lines, Rays, and (Directed Segments). pg 179-181

        if (Math.Abs(directionCoordinate) < float.Epsilon)
            return (positionCoordinate >= slabMinimum) && (positionCoordinate <= slabMaximum);

        // Compute intersection values of ray with near and far plane of slab
        var rayNearDistance = (slabMinimum - positionCoordinate) / directionCoordinate;
        var rayFarDistance = (slabMaximum - positionCoordinate) / directionCoordinate;

        if (rayNearDistance > rayFarDistance)
        {
            // Swap near and far distance
            var temp = rayFarDistance;
            rayNearDistance = rayFarDistance;
            rayFarDistance = temp;
        }

        // Compute the intersection of slab intersection intervals
        rayMinimumDistance = rayNearDistance > rayMinimumDistance
            ? rayNearDistance
            : rayMinimumDistance;
        rayMaximumDistance = rayFarDistance < rayMaximumDistance
            ? rayFarDistance
            : rayMaximumDistance;

        // Exit with no collision as soon as slab intersection becomes empty
        return rayMinimumDistance <= rayMaximumDistance;
    }
}