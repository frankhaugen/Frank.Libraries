using DecimalMath;
using Frank.Libraries.Calculators.Types;

namespace Frank.Libraries.Calculators.EuclideanCalculators
{
    public class EuclideanDistanceCalculator
    {
        public static decimal TwoDimensionalDistance(Vector2 origin, Vector2 destination)
        {
            var x = DecimalEx.Pow(origin.X - destination.X, 2);
            var y = DecimalEx.Pow(origin.Y - destination.Y, 2);
            var result = DecimalEx.Sqrt(x + y);
            return result;
        }

        public static decimal ThreeDimensionalDistance(ICartesianCoordinates origin, ICartesianCoordinates destination)
        {
            var x = DecimalEx.Pow(origin.X - destination.X, 2);
            var y = DecimalEx.Pow(origin.Y - destination.Y, 2);
            var z = DecimalEx.Pow(origin.Z - destination.Z, 2);
            var result = DecimalEx.Sqrt(x + y + z);
            return result;
        }
    }
}
