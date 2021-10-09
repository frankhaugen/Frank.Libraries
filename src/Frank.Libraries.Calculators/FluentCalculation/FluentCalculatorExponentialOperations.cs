using System;
 
namespace Frank.Libraries.Calculators.FluentCalculation
{
    public static class FluentCalculatorExponentialOperations
    {
        // int
        public static int Pow(this int source, int value) => PowerOf(source, value);
        public static int Sqrt(this int source) => SqrtOf(source);
         
        private static int PowerOf(int source, int value)
        {
            var result = new int();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static int SqrtOf(int source)
        {
            if (source is 0 or (int)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (int)2;
            var lastX = (int)-1;
            int nextX;
            var x = (int)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = x / 2 + halfS / x;
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // uint
        public static uint Pow(this uint source, int value) => PowerOf(source, value);
        public static uint Sqrt(this uint source) => SqrtOf(source);
         
        private static uint PowerOf(uint source, int value)
        {
            var result = new uint();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static uint SqrtOf(uint source)
        {
            if (source is 0 or (uint)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (uint)2;
            var lastX = uint.MinValue;
            uint nextX;
            var x = (uint)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = x / 2 + halfS / x;
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // short
        public static short Pow(this short source, int value) => PowerOf(source, value);
        public static short Sqrt(this short source) => SqrtOf(source);
         
        private static short PowerOf(short source, int value)
        {
            var result = new short();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static short SqrtOf(short source)
        {
            if (source is 0 or (short)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (short)2;
            var lastX = (short)-1;
            short nextX;
            var x = (short)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = (short)(x / 2 + halfS / x);
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // ushort
        public static ushort Pow(this ushort source, int value) => PowerOf(source, value);
        public static ushort Sqrt(this ushort source) => SqrtOf(source);
         
        private static ushort PowerOf(ushort source, int value)
        {
            var result = new ushort();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static ushort SqrtOf(ushort source)
        {
            if (source is 0 or (ushort)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (ushort)2;
            var lastX = ushort.MinValue;
            ushort nextX;
            var x = (ushort)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = (ushort)(x / 2 + halfS / x);
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // long
        public static long Pow(this long source, int value) => PowerOf(source, value);
        public static long Sqrt(this long source) => SqrtOf(source);
         
        private static long PowerOf(long source, int value)
        {
            var result = new long();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static long SqrtOf(long source)
        {
            if (source is 0 or (long)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (long)2;
            var lastX = (long)-1;
            long nextX;
            var x = (long)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = x / 2 + halfS / x;
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // ulong
        public static ulong Pow(this ulong source, int value) => PowerOf(source, value);
        public static ulong Sqrt(this ulong source) => SqrtOf(source);
         
        private static ulong PowerOf(ulong source, int value)
        {
            var result = new ulong();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static ulong SqrtOf(ulong source)
        {
            if (source is 0 or (ulong)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (ulong)2;
            var lastX = ulong.MinValue;
            ulong nextX;
            var x = (ulong)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = x / 2 + halfS / x;
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // float
        public static float Pow(this float source, int value) => PowerOf(source, value);
        public static float Sqrt(this float source) => SqrtOf(source);
         
        private static float PowerOf(float source, int value)
        {
            var result = new float();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static float SqrtOf(float source)
        {
            if (source is 0 or (float)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (float)2;
            var lastX = (float)-1;
            float nextX;
            var x = (float)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = x / 2 + halfS / x;
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // double
        public static double Pow(this double source, int value) => PowerOf(source, value);
        public static double Sqrt(this double source) => SqrtOf(source);
         
        private static double PowerOf(double source, int value)
        {
            var result = new double();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static double SqrtOf(double source)
        {
            if (source is 0 or (double)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (double)2;
            var lastX = (double)-1;
            double nextX;
            var x = (double)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = x / 2 + halfS / x;
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
        // decimal
        public static decimal Pow(this decimal source, int value) => PowerOf(source, value);
        public static decimal Sqrt(this decimal source) => SqrtOf(source);
         
        private static decimal PowerOf(decimal source, int value)
        {
            var result = new decimal();
            for (var i = 1; i < value; i++) result *= source;
            return result;
        }
        private static decimal SqrtOf(decimal source)
        {
            if (source is 0 or (decimal)DecimalConstants.SmallestNonZeroDec) return 0;
            var halfS = source / (decimal)2;
            var lastX = (decimal)-1;
            decimal nextX;
            var x = (decimal)Math.Sqrt(Convert.ToDouble(source));
            while (true)
            {
                nextX = x / 2 + halfS / x;
                if (nextX == x || nextX == lastX) break;
                lastX = x;
                x = nextX;
            }
            return nextX;
        }
         
    }
}
