using System.IO;
using BenchmarkDotNet.Attributes;
using Frank.Libraries.ML.LanguageDetection;

namespace Frank.Libraries.Tests.Benchmark.LanguageDetection;

[MemoryDiagnoser]
[ThreadingDiagnoser]
[DisassemblyDiagnoser]
public class Norwegian
{
    private readonly LanguageDetectionService _languageDetectionService = new(new LanguageDetectionOptions(int.MaxValue));
    private readonly string text = File.ReadAllText(Path.Combine("LanguageDetection", "Texts", "NorwegianSult.txt"));

    [Benchmark]
    public void Run()
    {
        var result = _languageDetectionService.Detect(text);
    }
}