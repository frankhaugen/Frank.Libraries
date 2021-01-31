using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Frank.Libraries.AI.LanguageDetection;
using Frank.Libraries.Security;

namespace Frank.Libraries.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmark>(new DebugInProcessConfig().WithOption(ConfigOptions.JoinSummary, true).WithOption(ConfigOptions.DontOverwriteResults, true).WithArtifactsPath("Reports"));
        }
    }

    //[SimpleJob(launchCount: 1, warmupCount: 1, targetCount: 1, invocationCount: 1)]
    [RunOncePerIteration]
    [MarkdownExporter]
    public class Benchmark
    {
        [Benchmark]
        public void PasswordHashing()
        {
            var passwordGenerator = new PasswordGenerator();
            var passwordHasher = new PasswordHasher();

            var password = passwordGenerator.GeneratePassword();
            var hash = passwordHasher.HashPassword(password);
            passwordHasher.CheckPasswordAgainstHash(password, hash);
        }

        [Benchmark]
        public void LanguageDetection()
        {
            var languageDetector = new LanguageDetectionService(new LanguageDetectionOptions());
            var text = "Hi, my name is Slim Sgady!";
            var language = languageDetector.Detect(text);
        }
    }
}
