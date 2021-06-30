using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Frank.Libraries.Calculators.Converters;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.CodeGeneration.Generators;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration
{
    public class ConversionsGeneratorTests : TestBase
    {
        public ConversionsGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public async Task GenerateTest()
        {
            var generator = new ConversionsGenerator();

            var result = generator.Generate(typeof(CoordinatesConverter).Namespace, "PrimitiveConversions", null, false);

            Output(result);
        }
    }
}
