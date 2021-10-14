using System.IO;
using Frank.Libraries.CodeGeneration.Generators.FuentCalculation;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration
{
    public class FluentCalculatorGeneratorTests : TestBase
    {
        public FluentCalculatorGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact(Skip = "")] public void GenerateBasicOpertaionsFluentCalculator() => Output(new FileInfo(Path.Combine(SolutionDirectory().FullName, "Frank.Libraries.Calculators", "FluentCalculation", "FluentCalculatorBasicOperations.cs")), FluentCalculatorBasicOperationsGenerator.Generate());
        [Fact(Skip = "")] public void GenerateExponentialOpertaionsFluentCalculator() => Output(new FileInfo(Path.Combine(SolutionDirectory().FullName, "Frank.Libraries.Calculators", "FluentCalculation", "FluentCalculatorExponentialOperations.cs")), FluentCalculatorExponentialOperationsGenerator.Generate());
        [Fact(Skip = "")] public void GeneratePrimitiveConversions() => Output(new FileInfo(Path.Combine(SolutionDirectory().FullName, "Frank.Libraries.Calculators", "FluentCalculation", "FluentCalculatorPrimitivesConversions.cs")), FluentCalculatorPrimitivesConversionsGenerator.Generate());
    }
}
