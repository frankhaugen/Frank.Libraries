using System;
using System.Numerics;
using Frank.Libraries.Calculators.FluentCalculation;

namespace Frank.Libraries.Calculators.EuclideanCalculators
{
    public class EuclideanDistanceCalculator
    {
        public static decimal TwoDimensionalDistance(Vector2 origin, Vector2 destination)
        {
            var x = origin.X.ToDecimal()
                          .Subtract(destination.X.ToDecimal())
                          .Pow(2);
            var y = origin.Y.ToDecimal()
                          .Subtract(destination.Y.ToDecimal())
                          .Pow(2);
            var result = (decimal)Math.Sqrt((x + y).ToDouble());
            return result;
        }

        public static decimal ThreeDimensionalDistance(Vector3 origin, Vector3 destination)
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
            return result;
        }
    }
}