using System;
using System.Collections.Generic;
using System.Linq;
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

    public class TestGeneratorTests : TestBase
    {
        public TestGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public async Task GenerateTest()
        {
            var generator = new TestGenerator();

            var result = generator.Generate(typeof(CoordinatesConverter).Namespace, typeof(Frank.Libraries.Time), new System.IO.DirectoryInfo("C:/repos/frankhaugen/Frank.Libraries/Frank.Libraries.Tests/Time/Generated"), true);

            Output(result);
        }

        [Fact]
        public async Task ReflectionTest()
        {
            var methods = typeof(Frank.Libraries.Time).GetMethods().Where(x => x.IsPublic).Select(x => new {
                x.Name,
                CallingConvention = x.CallingConvention.ToString(),
                MethodImplementationFlags = x.GetMethodImplementationFlags().ToString(),
                MemberType = x.MemberType.ToString(), 
                Soem = x.MemberType.ToString() 
            });
            Output(methods.FirstOrDefault());

            var defaultMembers = typeof(Frank.Libraries.Time).GetMembers().Select(x => new {
                x.Name,
                MemberType = x.MemberType.ToString(), 
            });
            Output(defaultMembers);
        }
    }
}
