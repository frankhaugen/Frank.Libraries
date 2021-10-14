using System.IO;
using Frank.Libraries.CodeGeneration.Generators;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration
{
    public class CultureEnumGeneratorTests : TestBase
    {
        public CultureEnumGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact(Skip = "")] public void GenerateBasicOpertaionsFluentCalculator() => Output(new FileInfo(Path.Combine(SolutionDirectory().FullName, "Frank.Libraries.Enums", "Countries", "Culture.cs")), CultureEnumGenerator.Generate("Frank.Libraries.Enums.Countries"));
    }
}