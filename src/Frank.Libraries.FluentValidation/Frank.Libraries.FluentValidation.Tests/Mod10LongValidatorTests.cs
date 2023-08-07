using TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.FluentValidation.Tests;

public class Mod10LongValidatorTests : TestBase
{
    public Mod10LongValidatorTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    //[Fact]
    public void TestMethod1()
    {
        // Arrange
        var mod10LongValidator = new Mod10LongValidator();

        // Act


        // Assert
    }
}