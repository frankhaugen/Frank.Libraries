using FluentAssertions;
using Xunit.Abstractions;

namespace Frank.Libraries.FluentValidation.Tests;

public class ThrowsRuleTests
{
    private readonly ITestOutputHelper _outputHelper;

    public ThrowsRuleTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Theory]
    [InlineData(0, 0, false)]
    [InlineData(2, 0, false)]
    [InlineData(0, 2, true)]
    [InlineData(2, 2, true)]
    public void ThrowsNot(int a, int b, bool isValid)
    {
        // Arrange
        var methodValidator = new MethodExecutionValidator();

        // Act
        var result = methodValidator.Validate(delegate { AMethod(a, b); });

        // Assert
        result.IsValid.Should()
              .Be(isValid);

        foreach (var validationFailure in result.Errors.Select(x => x.ToString()))
        {
            _outputHelper.WriteLine(validationFailure);
        }
    }

    [Theory]
    [InlineData(0, 0, false)]
    [InlineData(2, 0, false)]
    [InlineData(0, 2, true)]
    [InlineData(2, 2, true)]
    public void ThrowsNotSpecific(int a, int b, bool isValid)
    {
        // Arrange
        var methodValidator = new MethodExecutionValidator();

        // Act
        var result = methodValidator.Validate(delegate { AMethod(a, b); });

        // Assert
        result.IsValid.Should()
              .Be(isValid);

        foreach (var validationFailure in result.Errors.Select(x => x.ToString()))
        {
            _outputHelper.WriteLine(validationFailure);
        }
    }

    private void AMethod(int a, int b)
    {
        var sum = a / b;
    }
}