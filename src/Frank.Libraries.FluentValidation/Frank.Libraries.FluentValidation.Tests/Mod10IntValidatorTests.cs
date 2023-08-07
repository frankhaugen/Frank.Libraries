using TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.FluentValidation.Tests;

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