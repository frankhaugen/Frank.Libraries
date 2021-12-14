using System;
using System.IO;
using System.Threading.Tasks;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.CodeGeneration.Generators;
using Frank.Libraries.Extensions;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration.Generators;

public class TestGeneratorTests
{
    private readonly ITestOutputHelper _outputHelper;

    private const string Something = "Frank.Libraries.Tests";

    public TestGeneratorTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Theory]
    [InlineData(typeof(FluentCalculatorBasicOperations), true)]
    public async Task RunTestGenerator(Type type, bool writeFile)
    {
        var localNamespace = type.Namespace.Replace("Frank.Libraries.", "");
        var solutionDirectory = new DirectoryInfo("").GetSolutionDirectory();
        var testProjectName = "Frank.Libraries.Tests";
        var testProjectDirectory = solutionDirectory.GetSubDirectory(testProjectName);

        var directories = localNamespace.Split(".");

        var result = new TestGenerator().Generate(type.Namespace, type);
        _outputHelper.WriteLine(result);

        if (writeFile)
        {
        }
    }
}