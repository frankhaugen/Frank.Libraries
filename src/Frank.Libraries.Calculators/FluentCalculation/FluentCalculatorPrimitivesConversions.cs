using System;
 
namespace Frank.Libraries.Calculators.FluentCalculation
{
    public static class FluentCalculatorPrimitivesConversions
    {
        // Int 
        public static uint ToUint(this int source) => Convert.ToUInt32(source);
        public static short ToShort(this int source) => Convert.ToInt16(source);
        public static ushort ToUshort(this int source) => Convert.ToUInt16(source);
        public static long ToLong(this int source) => Convert.ToInt64(source);
        public static ulong ToUlong(this int source) => Convert.ToUInt64(source);
        public static float ToFloat(this int source) => Convert.ToSingle(source);
        public static double ToDouble(this int source) => Convert.ToDouble(source);
        public static decimal ToDecimal(this int source) => Convert.ToDecimal(source);

        // Uint 
        public static int ToInt(this uint source) => Convert.ToInt32(source);
        public static short ToShort(this uint source) => Convert.ToInt16(source);
        public static ushort ToUshort(this uint source) => Convert.ToUInt16(source);
        public static long ToLong(this uint source) => Convert.ToInt64(source);
        public static ulong ToUlong(this uint source) => Convert.ToUInt64(source);
        public static float ToFloat(this uint source) => Convert.ToSingle(source);
        public static double ToDouble(this uint source) => Convert.ToDouble(source);
        public static decimal ToDecimal(this uint source) => Convert.ToDecimal(source);

        // Short 
        public static int ToInt(this short source) => Convert.ToInt32(source);
        public static uint ToUint(this short source) => Convert.ToUInt32(source);
        public static ushort ToUshort(this short source) => Convert.ToUInt16(source);
        public static long ToLong(this short source) => Convert.ToInt64(source);
        public static ulong ToUlong(this short source) => Convert.ToUInt64(source);
        public static float ToFloat(this short source) => Convert.ToSingle(source);
        public static double ToDouble(this short source) => Convert.ToDouble(source);
        public static decimal ToDecimal(this short source) => Convert.ToDecimal(source);

        // Ushort 
        public static int ToInt(this ushort source) => Convert.ToInt32(source);
        public static uint ToUint(this ushort source) => Convert.ToUInt32(source);
        public static short ToShort(this ushort source) => Convert.ToInt16(source);
        public static long ToLong(this ushort source) => Convert.ToInt64(source);
        public static ulong ToUlong(this ushort source) => Convert.ToUInt64(source);
        public static float ToFloat(this ushort source) => Convert.ToSingle(source);
        public static double ToDouble(this ushort source) => Convert.ToDouble(source);
        public static decimal ToDecimal(this ushort source) => Convert.ToDecimal(source);

        // Long 
        public static int ToInt(this long source) => Convert.ToInt32(source);
        public static uint ToUint(this long source) => Convert.ToUInt32(source);
        public static short ToShort(this long source) => Convert.ToInt16(source);
        public static ushort ToUshort(this long source) => Convert.ToUInt16(source);
        public static ulong ToUlong(this long source) => Convert.ToUInt64(source);
        public static float ToFloat(this long source) => Convert.ToSingle(source);
        public static double ToDouble(this long source) => Convert.ToDouble(source);
        public static decimal ToDecimal(this long source) => Convert.ToDecimal(source);

        // Ulong 
        public static int ToInt(this ulong source) => Convert.ToInt32(source);
        public static uint ToUint(this ulong source) => Convert.ToUInt32(source);
        public static short ToShort(this ulong source) => Convert.ToInt16(source);
        public static ushort ToUshort(this ulong source) => Convert.ToUInt16(source);
        public static long ToLong(this ulong source) => Convert.ToInt64(source);
        public static float ToFloat(this ulong source) => Convert.ToSingle(source);
        public static double ToDouble(this ulong source) => Convert.ToDouble(source);
        public static decimal ToDecimal(this ulong source) => Convert.ToDecimal(source);

        // Float 
        public static int ToInt(this float source) => Convert.ToInt32(source);
        public static uint ToUint(this float source) => Convert.ToUInt32(source);
        public static short ToShort(this float source) => Convert.ToInt16(source);
        public static ushort ToUshort(this float source) => Convert.ToUInt16(source);
        public static long ToLong(this float source) => Convert.ToInt64(source);
        public static ulong ToUlong(this float source) => Convert.ToUInt64(source);
        public static double ToDouble(this float source) => Convert.ToDouble(source);
        public static decimal ToDecimal(this float source) => Convert.ToDecimal(source);

        // Double 
        public static int ToInt(this double source) => Convert.ToInt32(source);
        public static uint ToUint(this double source) => Convert.ToUInt32(source);
        public static short ToShort(this double source) => Convert.ToInt16(source);
        public static ushort ToUshort(this double source) => Convert.ToUInt16(source);
        public static long ToLong(this double source) => Convert.ToInt64(source);
        public static ulong ToUlong(this double source) => Convert.ToUInt64(source);
        public static float ToFloat(this double source) => Convert.ToSingle(source);
        public static decimal ToDecimal(this double source) => Convert.ToDecimal(source);

        // Decimal 
        public static int ToInt(this decimal source) => Convert.ToInt32(source);
        public static uint ToUint(this decimal source) => Convert.ToUInt32(source);
        public static short ToShort(this decimal source) => Convert.ToInt16(source);
        public static ushort ToUshort(this decimal source) => Convert.ToUInt16(source);
        public static long ToLong(this decimal source) => Convert.ToInt64(source);
        public static ulong ToUlong(this decimal source) => Convert.ToUInt64(source);
        public static float ToFloat(this decimal source) => Convert.ToSingle(source);
        public static double ToDouble(this decimal source) => Convert.ToDouble(source);

    }
}
