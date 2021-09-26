using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using Frank.Libraries.AI.LanguageDetection;

namespace Frank.Libraries.Tests.Benchmark.LanguageDetection
{
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    [DisassemblyDiagnoser]
    public class Norwegian
    {
        private string text = File.ReadAllText(Path.Combine("LanguageDetection", "Texts", "NorwegianSult.txt"));
        private LanguageDetectionService _languageDetectionService = new LanguageDetectionService(new LanguageDetectionOptions(Int32.MaxValue));

        [Benchmark]
        public void Run()
        {
            var result = _languageDetectionService.Detect(text);
        }
    }
}