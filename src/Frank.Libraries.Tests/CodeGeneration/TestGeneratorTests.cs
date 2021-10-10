using System.Linq;
using System.Threading.Tasks;
using Frank.Libraries.CodeGeneration.Generators;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.CodeGeneration
{
    public class TestGeneratorTests : TestBase
    {
        public TestGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        //[Fact]
        public async Task ReflectionTest()
        {
            var methods = typeof(Frank.Libraries.CodeGeneration.Generators.ConstantsGenerator).GetMethods().Where(x => x.IsPublic).Select(x => new
            {
                x.Name,
                CallingConvention = x.CallingConvention.ToString(),
                MethodImplementationFlags = x.GetMethodImplementationFlags().ToString(),
                MemberType = x.MemberType.ToString(),
                Soem = x.MemberType.ToString()
            });
            Output(methods.FirstOrDefault());

            var defaultMembers = typeof(ConstantsGenerator).GetMembers().Select(x => new
            {
                x.Name,
                MemberType = x.MemberType.ToString(),
            });
            Output(defaultMembers);
        }
    }
}