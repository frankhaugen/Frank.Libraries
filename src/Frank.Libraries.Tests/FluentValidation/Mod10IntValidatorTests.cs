using Frank.Libraries.FluentValidation;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.FluentValidation;

public class Mod10IntValidatorTests : TestBase
{
    public Mod10IntValidatorTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    //[Fact]
    public void TestMethod1()
    {
        // Arrange
        var mod10IntValidator = new Mod10IntValidator();

        // Act


        // Assert
    }
}