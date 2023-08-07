using Frank.Libraries.FluentValidation;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.FluentValidation;

public class Mod10ShortValidatorTests : TestBase
{
    public Mod10ShortValidatorTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    //[Fact]
    public void TestMethod1()
    {
        // Arrange
        var mod10ShortValidator = new Mod10ShortValidator();

        // Act


        // Assert
    }
}