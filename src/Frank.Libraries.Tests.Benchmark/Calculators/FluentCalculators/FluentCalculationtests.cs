using System;
using BenchmarkDotNet.Attributes;

namespace Frank.Libraries.Tests.Benchmark.Calculators.FluentCalculators
{
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    [DisassemblyDiagnoser]
    public class FluentCalculationBenchmarks
    {
        [Params(1000)] public int Exponent { get; set; }

        [Benchmark]
        public void Fluent()
        {
            var value = 3.0m;
            // value.Pow(Exponent);
        }

        [Benchmark]
        public void Standard()
        {
            var value = 3.0;
            Math.Pow(value, Exponent);
        }
    }
}