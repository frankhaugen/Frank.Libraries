namespace Frank.Libraries.Calculators.FluentCalculation
{
    public static class FluentCalculator
    {
        public static int Add(this int source, int value) => source + value;

        public static decimal Add(this decimal source, decimal value) => source + value;

        public static double Add(this double source, double value) => source + value;

        public static int Subtract(this int source, int value) => source - value;

        public static decimal Subtract(this decimal source, decimal value) => source - value;

        public static double Subtract(this double source, double value) => source - value;

        public static int Multiply(this int source, int value) => source * value;

        public static decimal Multiply(this decimal source, decimal value) => source * value;

        public static double Multiply(this double source, double value) => source * value;

        public static decimal Divide(this int source, int value) => source / value;

        public static decimal Divide(this decimal source, decimal value) => source / value;

        public static double Divide(this double source, double value) => source / value;
    }
}