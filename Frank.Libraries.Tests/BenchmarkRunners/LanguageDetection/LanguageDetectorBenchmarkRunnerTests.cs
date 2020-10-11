using System.IO;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Frank.Libraries.Benchmarks;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.BenchmarkRunners.LanguageDetection
{
    public class LanguageDetectorBenchmarkRunnerTests
    {
        private readonly ITestOutputHelper _outputHelper;

        /// <inheritdoc />
        public LanguageDetectorBenchmarkRunnerTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Run()
        {
            var summery = BenchmarkRunner.Run<Benchmark>(new DebugInProcessConfig());
            var file = File.ReadAllText(summery.LogFilePath);
            _outputHelper.WriteLine(file);
        }
    }
}
