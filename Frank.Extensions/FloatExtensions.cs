using System;

namespace Frank.Extensions
{
    public static class FloatExtensions
    {

        public static double ToDouble(this float value)
        {
            return Convert.ToDouble(value);
        }

        public static decimal ToDecimal(this float value)
        {
            return Convert.ToDecimal(value);
        }
    }
}
