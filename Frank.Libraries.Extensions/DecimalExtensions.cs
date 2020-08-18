using System;

namespace Frank.Libraries.Extensions
{
    public static class DecimalExtensions
    {
        public static float ToFloat(this decimal value)
        {
            return Convert.ToSingle(value);
        }

        public static double ToDouble(this decimal value)
        {
            return Convert.ToDouble(value);
        }

        public static double ToInteger(this decimal value)
        {
            return Convert.ToInt32(Math.Round(value, 0, MidpointRounding.AwayFromZero));
        }
    }
}
