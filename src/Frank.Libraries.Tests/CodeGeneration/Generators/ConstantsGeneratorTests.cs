using System.Collections.Generic;
using System.IO;
using Frank.Libraries.CodeGeneration.Generators;
using Frank.Libraries.CodeGeneration.Models;
using Frank.Libraries.Json;
using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Tests.TestingInfrastructure.Files;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration.Generators
{
    public class ConstantsGeneratorTests : TestBase
    {
        private const string RootNamespace = "Frank.Libraries.Calculators";
        private const string Namespace = "FluentCalculation";

        public ConstantsGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void GenerateIrcErrorMessages()
        {
            // Arrange
            var createFile = false;
            var errorMessages = TestFiles.IrcErrorMessages;
            var resources = errorMessages.FromJson<List<Resource>>();
            var generator = new ConstantsGenerator(resources);
            var className = "ErrorMessages";
            var @namespace = "Frank.Libraries.IRC";

            // Act
            var result = generator.Generate(@namespace, className);

            // Assert
            Output(result);
            if (createFile) Output(new FileInfo(Path.Combine(SolutionDirectory().FullName, RootNamespace, Namespace, $"{className}.cs")), result);
        }
    }
}