using System;
using System.ComponentModel.DataAnnotations;

namespace Frank.Libraries.Calculators
{
    public static class BeerCalculator
    {
        public static decimal Pow(this decimal source, int exponent) => PowerOf(source, exponent);

        private static decimal PowerOf(decimal value, int powerOf)
        {
            var result = 0m;
            for (var i = 1; i < powerOf; i++) result *= value;
            return result;
        }





    }
}
