using Frank.Libraries.FluentValidation;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.FluentValidation
{
    public class Mod10LongValidatorTests : TestBase
    {
        //[Fact]
        public void TestMethod1()
        {
            // Arrange
            var mod10LongValidator = new Mod10LongValidator();

            // Act


            // Assert
        }

        public Mod10LongValidatorTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
    }
}