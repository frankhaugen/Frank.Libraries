using BenchmarkDotNet.Running;
using Frank.Libraries.Tests.Benchmark.Json;
using Frank.Libraries.Tests.Benchmark.LanguageDetection;

namespace Frank.Libraries.Tests.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run<JsonContextBenchmark>();
            BenchmarkRunner.Run<Norwegian>();
        }
    }
}
