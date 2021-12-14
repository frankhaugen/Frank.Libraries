using System;

namespace Frank.Libraries.Extensions
{
    public static class DecimalExtensions
    {
        public static float ToFloat(this decimal value) => Convert.ToSingle(value);

        public static double ToDouble(this decimal value) => Convert.ToDouble(value);

        public static int ToInteger(this decimal value) => Convert.ToInt32(Math.Round(value, 0, MidpointRounding.AwayFromZero));

        public static decimal ToPowerOf(this decimal value, int powerOf)
        {
            if (powerOf < 1) return 0.0m;
            if (powerOf == 1) return value;

            var result = value;

            for (var i = 1; i < powerOf; i++)
            {
                result *= value;
            }

            return result;
        }
    }
}