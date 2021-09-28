namespace Frank.Libraries.Calculators.FluentCalculation
{
    public static class FluentCalculator
    {
        // Add 
        public static int Add(this int source, int value) => (int) (source + value);
        public static short Add(this short source, short value) => (short) (source + value);
        public static long Add(this long source, long value) => (long) (source + value);
        public static float Add(this float source, float value) => (float) (source + value);
        public static double Add(this double source, double value) => (double) (source + value);
        public static decimal Add(this decimal source, decimal value) => (decimal) (source + value);


        // Subtract 
        public static int Subtract(this int source, int value) => (int) (source - value);
        public static short Subtract(this short source, short value) => (short) (source - value);
        public static long Subtract(this long source, long value) => (long) (source - value);
        public static float Subtract(this float source, float value) => (float) (source - value);
        public static double Subtract(this double source, double value) => (double) (source - value);
        public static decimal Subtract(this decimal source, decimal value) => (decimal) (source - value);


        // Multiply 
        public static int Multiply(this int source, int value) => (int) (source * value);
        public static short Multiply(this short source, short value) => (short) (source * value);
        public static long Multiply(this long source, long value) => (long) (source * value);
        public static float Multiply(this float source, float value) => (float) (source * value);
        public static double Multiply(this double source, double value) => (double) (source * value);
        public static decimal Multiply(this decimal source, decimal value) => (decimal) (source * value);


        // Divide 
        public static decimal Divide(this int source, int value) => (decimal) (source / value);
        public static decimal Divide(this short source, short value) => (decimal) (source / value);
        public static decimal Divide(this long source, long value) => (decimal) (source / value);
        public static float Divide(this float source, float value) => (float) (source / value);
        public static double Divide(this double source, double value) => (double) (source / value);
        public static decimal Divide(this decimal source, decimal value) => (decimal) (source / value);
    }
}
