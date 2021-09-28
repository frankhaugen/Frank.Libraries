using DecimalMath;
using Frank.Libraries.Calculators.Types;

namespace Frank.Libraries.Calculators.Converters
{
    public class CoordinatesConverter
    {
        public static IPolarCoordinates CartesianToSpherical(ICartesianCoordinates coordinates)
        {
            var result = new PolarCoordinates();

            result.Radius = DecimalEx.Sqrt((coordinates.X * coordinates.X)
                                      + (coordinates.Y * coordinates.Y)
                                      + (coordinates.Z * coordinates.Z));
            result.Inclination = DecimalEx.ACos(coordinates.Z / result.Radius);
            result.Azimuth = DecimalEx.ATan(coordinates.Y / coordinates.X);

            return result;
        }

        public static ICartesianCoordinates SphericalToCartesian(IPolarCoordinates polarCoordinates)
        {
            var result = new Vector3();

            result.X = polarCoordinates.Radius * DecimalEx.Sin(polarCoordinates.Inclination) * DecimalEx.Cos(polarCoordinates.Azimuth);
            result.Y = polarCoordinates.Radius * DecimalEx.Sin(polarCoordinates.Inclination) * DecimalEx.Sin(polarCoordinates.Azimuth);
            result.Z = polarCoordinates.Radius * DecimalEx.Cos(polarCoordinates.Inclination);

            return result;
        }
    }
}