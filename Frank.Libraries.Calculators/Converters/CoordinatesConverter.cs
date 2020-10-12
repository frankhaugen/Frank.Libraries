using DecimalMath;
using Frank.Libraries.Calculators.Types;

namespace Frank.Libraries.Calculators.Converters
{
    public class CoordinatesConverter
    {
        public IPolarCoordinates CartesianToSpherical(ICartesianCoordinates coordinates)
        {
            var result = new PolarCoordinates();
            if (coordinates.X == 0)
                coordinates.X = decimal.MinValue;

            result.R = DecimalEx.Sqrt((coordinates.X * coordinates.X)
                                      + (coordinates.Y * coordinates.Y)
                                      + (coordinates.Z * coordinates.Z));
            result.P = DecimalEx.ATan(coordinates.Y / coordinates.X);
            if (coordinates.X < 0)
                result.P += DecimalEx.Pi;
            result.E = DecimalEx.ASin(coordinates.Y / result.R);

            return result;
        }

        public static ICartesianCoordinates SphericalToCartesian(IPolarCoordinates polarCoordinates)
        {
            var result = new Vector3();
            var a = polarCoordinates.R * DecimalEx.Cos(polarCoordinates.E);
            result.X = a * DecimalEx.Cos(polarCoordinates.P);
            result.Y = polarCoordinates.R * DecimalEx.Sin(polarCoordinates.E);
            result.Z = a * DecimalEx.Sin(polarCoordinates.P);

            return result;
        }
    }
}
