using System;
using System.Numerics;
using DecimalMath;
using Frank.Libraries.Calculators.Types;

namespace Frank.Libraries.Calculators.FluentCalculation
{
    public static class FluentCalculatorGeometricCalculation
    {
        public static PolarCoordinates ToPolar(this CartesianCoordinates coordinates)
        {
            var result = new PolarCoordinates();

            result.Radius = DecimalEx.Sqrt((coordinates.X * coordinates.X)
                                           + (coordinates.Y * coordinates.Y)
                                           + (coordinates.Z * coordinates.Z));
            result.Inclination = DecimalEx.ACos(coordinates.Z / result.Radius);
            result.Azimuth = DecimalEx.ATan(coordinates.Y / coordinates.X);

            return result;
        }

        public static CartesianCoordinates ToCartesian(this PolarCoordinates polarCoordinates)
        {
            var result = new CartesianCoordinates
            {
                X = polarCoordinates.Radius * DecimalEx.Sin(polarCoordinates.Inclination) * DecimalEx.Cos(polarCoordinates.Azimuth),
                Y = polarCoordinates.Radius * DecimalEx.Sin(polarCoordinates.Inclination) * DecimalEx.Sin(polarCoordinates.Azimuth),
                Z = polarCoordinates.Radius * DecimalEx.Cos(polarCoordinates.Inclination)
            };

            return result;
        }

        public static float Distance(this Vector2 origin, Vector2 destination)
        {
            var x = origin.X.ToDecimal()
                          .Subtract(destination.X.ToDecimal())
                          .Pow(2);
            var y = origin.Y.ToDecimal()
                          .Subtract(destination.Y.ToDecimal())
                          .Pow(2);
            var result = (decimal)Math.Sqrt((x + y).ToDouble());
            return result.ToFloat();
        }

        public static float Distance(this Vector3 origin, Vector3 destination)
        {
            var x = origin.X.Subtract(destination.X)
                          .ToDecimal()
                          .Pow(2);
            var y = origin.Y.Subtract(destination.Y)
                          .ToDecimal()
                          .Pow(2);
            var z = origin.Z.Subtract(destination.Z)
                          .ToDecimal()
                          .Pow(2);
            var result = x.Add(y)
                          .Add(z)
                          .Sqrt();
            return result.ToFloat();
        }

        public static decimal Distance(this CartesianCoordinates origin, CartesianCoordinates destination)
        {
            var x = origin.X.Subtract(destination.X)
                          .Pow(2);
            var y = origin.Y.Subtract(destination.Y)
                          .Pow(2);
            var z = origin.Z.Subtract(destination.Z)
                          .Pow(2);
            var result = x.Add(y)
                          .Add(z)
                          .Sqrt();
            return result;
        }

        public static float Distance(this Vector3 origin, CartesianCoordinates destination)
        {
            var x = origin.X.ToDecimal()
                          .Subtract(destination.X)
                          .Pow(2);
            var y = origin.Y.ToDecimal()
                          .Subtract(destination.Y)
                          .Pow(2);
            var z = origin.Z.ToDecimal()
                          .Subtract(destination.Z)
                          .Pow(2);
            var result = x.Add(y)
                          .Add(z)
                          .Sqrt();
            return result.ToFloat();
        }

        public static decimal Distance(this CartesianCoordinates origin, Vector3 destination)
        {
            var x = origin.X.Subtract(destination.X.ToDecimal())
                          .Pow(2);
            var y = origin.Y.Subtract(destination.Y.ToDecimal())
                          .Pow(2);
            var z = origin.Z.Subtract(destination.Z.ToDecimal())
                          .Pow(2);
            var result = x.Add(y)
                          .Add(z)
                          .Sqrt();
            return result;
        }
    }
}