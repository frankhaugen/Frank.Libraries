using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.CodeGeneration.Generators;
using Frank.Libraries.Extensions;
using Frank.Libraries.Fiken.Clients;
using Frank.Libraries.Gaming.Starfinder;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration.Generators;

public class TestGeneratorTests
{
    private const string Something = "Frank.Libraries.Tests";
    private readonly ITestOutputHelper _outputHelper;

    public TestGeneratorTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Theory]
    [InlineData(typeof(FluentCalculatorBasicOperations), false)]
    [InlineData(typeof(FluentCalculatorPrimitivesConversions), false)]
    [InlineData(typeof(AccountsClient), false)]
    [InlineData(typeof(UserClient), false)]
    [InlineData(typeof(CompaniesClient), false)]
    // [InlineData(typeof(XkcdClient), false)]
    [InlineData(typeof(StarshipSheet), false)]
    public async Task RunTestGenerator(Type type, bool writeFile)
    {
        var localNamespace = type.Namespace.Replace("Frank.Libraries.", "");
        var solutionDirectory = DirectoryInfoHelper.GetSolutionDirectory();

        var testProjectName = "Frank.Libraries.Tests";
        var testProjectDirectory = solutionDirectory.GetSubDirectory(testProjectName);

        var directories = localNamespace.Split(".");
        var allDirectories = directories.Prepend(testProjectDirectory.FullName)
                                        .ToArray();
        var namespaceDirectory = new DirectoryInfo(Path.Combine(allDirectories));

        var testFilename = type.Name + "Tests.cs";
        var testFilePath = Path.Combine(namespaceDirectory.FullName, testFilename);
        var testFile = new FileInfo(testFilePath);

        var result = new TestGenerator().Generate(type.Namespace.Replace("Frank.Libraries.", "Frank.Libraries.Tests."), type, new List<string> { "ToString", "Equals", "GetHashCode", "GetType" });
        _outputHelper.WriteLine(result);

        if (writeFile)
        {
            namespaceDirectory.Create();
            await testFile.WriteAllTextAsync(result);
            _outputHelper.WriteLine(testFilename);
            _outputHelper.WriteLine(testFile.FullName);
        }
    }
}