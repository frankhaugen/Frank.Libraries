using DecimalMath;
using Frank.Libraries.Calculators.Types;

namespace Frank.Libraries.Calculators.Converters
{
    public class CoordinatesConverter
    {
        public static PolarCoordinates CartesianToSpherical(CartesianCoordinates coordinates)
        {
            var result = new PolarCoordinates();

            result.Radius = DecimalEx.Sqrt((coordinates.X * coordinates.X)
                                      + (coordinates.Y * coordinates.Y)
                                      + (coordinates.Z * coordinates.Z));
            result.Inclination = DecimalEx.ACos(coordinates.Z / result.Radius);
            result.Azimuth = DecimalEx.ATan(coordinates.Y / coordinates.X);

            return result;
        }

        public static CartesianCoordinates SphericalToCartesian(PolarCoordinates polarCoordinates)
        {
            var result = new CartesianCoordinates
            {
                X = polarCoordinates.Radius * DecimalEx.Sin(polarCoordinates.Inclination) * DecimalEx.Cos(polarCoordinates.Azimuth),
                Y = polarCoordinates.Radius * DecimalEx.Sin(polarCoordinates.Inclination) * DecimalEx.Sin(polarCoordinates.Azimuth),
                Z = polarCoordinates.Radius * DecimalEx.Cos(polarCoordinates.Inclination)
            };

            return result;
        }

    }
}