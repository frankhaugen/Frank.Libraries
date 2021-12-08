using System.Threading.Tasks;
using Frank.Libraries.CodeGeneration.Generators;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration.Generators;

public class TestGeneratorTests
{
    private readonly TestGenerator _generator;
    private readonly ITestOutputHelper _outputHelper;
    public TestGeneratorTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _generator = new TestGenerator();
    }

    [Fact]
    public async Task RunTestGenerator()
    {
        var type = typeof(Frank.Libraries.Calculators.FluentCalculation.FluentCalculatorBasicOperations);
        var result = _generator.Generate(type.Namespace, type);
        _outputHelper.WriteLine(result);
    }
}