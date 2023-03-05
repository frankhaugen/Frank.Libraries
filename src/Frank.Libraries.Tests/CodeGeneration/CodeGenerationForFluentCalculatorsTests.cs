using System;
using System.IO;
using Frank.Libraries.CodeGeneration.Generators;
using Frank.Libraries.CodeGeneration.Generators.FuentCalculation;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration;

public class CodeGenerationForCalculatorsTests : TestBase
{
    private const string RootNamespace = "Frank.Libraries.Calculators";
    private const string Namespace = "FluentCalculation";

    public CodeGenerationForCalculatorsTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Theory]
    [InlineData(typeof(FluentCalculatorBasicOperationsGenerator), false)]
    [InlineData(typeof(FluentCalculatorExponentialOperationsGenerator), false)]
    [InlineData(typeof(FluentCalculatorPrimitivesConversionsGenerator), false)]
    public void Generate(Type generatorType, bool createFile)
    {
        // Arrange
        var generator = Activator.CreateInstance(generatorType) as IGenerator;
        var className = generatorType.Name.Replace("Generator", "");
        var @namespace = string.Join(".", RootNamespace, Namespace);

        // Act
        var result = generator.Generate(@namespace, className);

        // Assert
        Output(result);
        if (createFile)
        {
            Output(new FileInfo(Path.Combine(SolutionDirectory()
                                                 .FullName, RootNamespace, Namespace, $"{className}.cs")), result);
        }
    }
}