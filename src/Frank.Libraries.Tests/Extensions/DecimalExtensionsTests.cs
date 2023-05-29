using FluentAssertions;
using Frank.Libraries.Calculators.FluentCalculation;

namespace Frank.Libraries.Tests.Extensions;

public class DecimalExtensionsTests
{
    [Theory]
    [InlineData(2.0, 2.0)]
    [InlineData(2.1, 2.1)]
    [InlineData(2.5, 2.5)]
    [InlineData(2.123456789123456789123456789, 2.1234567)]
    public void ToFloat(decimal value, float expected)
    {
        // Arrange

        // Act
        var result = value.ToFloat();

        // Assert
        result.Should()
              .Be(expected);
    }

    [Theory]
    [InlineData(2.0, 2.0)]
    [InlineData(2.1, 2.1)]
    [InlineData(2.5, 2.5)]
    [InlineData(2.123456789, 2.123456789)]
    public void ToDouble(decimal value, double expected)
    {
        // Arrange

        // Act
        var result = value.ToDouble();

        // Assert
        result.Should()
              .Be(expected);
    }

    [Theory]
    [InlineData(2.0, 2)]
    [InlineData(2.1, 2)]
    [InlineData(2.5, 2)]
    [InlineData(2.55, 3)]
    [InlineData(2.50000000001, 3)]
    public void ToInteger(decimal value, int expected)
    {
        // Arrange

        // Act
        var result = value.ToInt();

        // Assert
        result.Should()
              .Be(expected);
    }

    [Theory]
    [InlineData(2.0, 2, 4.0)]
    [InlineData(2.0, 1, 2.0)]
    [InlineData(1.0, 1, 1.0)]
    public void ToPowerOf(decimal value, int powerOf, decimal expected)
    {
        // Arrange

        // Act
        var result = value.Pow(powerOf);

        // Assert
        result.Should()
              .Be(expected);
    }
}