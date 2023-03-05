using BenchmarkDotNet.Running;
using Frank.Libraries.Tests.Benchmark.Calculators.FluentCalculators;

namespace Frank.Libraries.Tests.Benchmark;

internal class Program
{
    private static void Main(string[] args) =>
        // BenchmarkRunner.Run<JsonContextBenchmark>();
        // BenchmarkRunner.Run<Norwegian>();
        BenchmarkRunner.Run<FluentCalculationBenchmarks>();
}