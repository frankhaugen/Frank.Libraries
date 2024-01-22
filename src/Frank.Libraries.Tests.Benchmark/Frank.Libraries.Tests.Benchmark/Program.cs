using BenchmarkDotNet.Running;
using Frank.Libraries.Tests.Benchmark.LanguageDetection;

namespace Frank.Libraries.Tests.Benchmark;

internal class Program
{
    private static void Main(string[] args) =>
        // BenchmarkRunner.Run<DataStorageBenchmarks>();
        // BenchmarkRunner.Run<JsonContextBenchmark>();
        BenchmarkRunner.Run<Norwegian>();
        // BenchmarkRunner.Run<FluentCalculationBenchmarks>();
        // BenchmarkRunner.Run<FaceFactoryBenchmark>(new DebugBuildConfig());
}