using System.Collections.Generic;
using System.IO;
using Frank.Libraries.CodeGeneration.Generators;
using Frank.Libraries.CodeGeneration.Models;
using Frank.Libraries.Json;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Generators
{
    public class ConstantsGeneratorTests : TestBase
    {
        public ConstantsGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        //[Fact]
        public void Generate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var constantsGenerator = new ConstantsGenerator();
            string namespaceName = "Frank.Libraries.IRC.Constants";
            string className = "ErrorMessages";
            var resources = File.ReadAllText(Path.Combine("C:/", "temp", "resources.json")).FromJson<List<Resource>>();
            var directoryInfo = new DirectoryInfo("C:/repos/frankhaugen/Frank.Libraries/Frank.Libraries.IRC/Constants/");
            bool saveToFile = true;

            // Act
            var result = constantsGenerator.Generate(
                namespaceName,
                className,
                resources,
                directoryInfo,
                saveToFile);

            // Assert
            Output(result);
        }
    }
}