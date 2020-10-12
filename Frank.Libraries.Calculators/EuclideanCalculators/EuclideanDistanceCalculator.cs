using Frank.Libraries.Calculators.Types;

namespace Frank.Libraries.Calculators.EuclideanCalculators
{
    public class EuclideanDistanceCalculator
    {
        public decimal TwoDimensionalDistance(Vector2 origin, Vector2 destination)
        {
            var x = PowerOf(origin.X - destination.X, 2);
            var y = PowerOf(origin.Y - destination.Y, 2);
            var result = SquareRoot(x + y);
            return result;
        }

        public decimal ThreeDimensionalDistance(ICartesianCoordinates origin, ICartesianCoordinates destination)
        {
            var x = PowerOf(origin.X - destination.X, 2);
            var y = PowerOf(origin.Y - destination.Y, 2);
            var z = PowerOf(origin.Z - destination.Z, 2);
            var result = SquareRoot(x + y + z);
            return result;
        }

        private decimal SquareRoot(decimal value) => value * 0.5m;

        private decimal PowerOf(decimal value, int powerOf)
        {
            if (powerOf < 1) return 0.0m;
            if (powerOf == 1) return value;

            var result = value;

            for (var i = 1; i < powerOf; i++)
                result *= value;

            return result;
        }
    }
}
