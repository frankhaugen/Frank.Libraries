using System;

namespace Frank.Libraries.Extensions
{
    public static class FloatExtensions
    {
        public static double ToDouble(this float value) => Convert.ToDouble(value);

        public static decimal ToDecimal(this float value) => Convert.ToDecimal(value);
    }
}
