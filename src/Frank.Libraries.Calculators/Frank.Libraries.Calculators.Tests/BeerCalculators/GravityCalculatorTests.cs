using FluentAssertions;
using Frank.Libraries.Calculators.BeerCalculators;

namespace Frank.Libraries.Calculators.Tests.BeerCalculators;

public class GravityCalculatorTests
{
    [Theory]
    [InlineData(1.040, 100.0, 1.084)]
    [InlineData(1.040, 90.0, 1.077)]
    [InlineData(1.040, 80.0, 1.069)]
    [InlineData(1.040, 70.0, 1.063)]
    [InlineData(1.040, 60.0, 1.056)]
    [InlineData(1.040, 50.0, 1.051)]
    [InlineData(1.040, 40.0, 1.047)]
    [InlineData(1.040, 30.0, 1.043)]
    [InlineData(1.040, 20.0, 1.040)]
    public void Calculate(decimal specificGravity, decimal temperature, decimal expected, decimal calibrationTemperature = 20.0m)
    {
        // Arrange
        var gravityCalculator = new GravityCalculator();

        // Act
        var result = gravityCalculator.Calculate(specificGravity, temperature, calibrationTemperature);

        // Assert
        result.Should()
              .BeApproximately(expected, 0.00099m);
    }

    [Theory]
    [InlineData(1.040, 212.0, 1.084)]
    [InlineData(1.040, 194.0, 1.077)]
    [InlineData(1.040, 176.0, 1.069)]
    [InlineData(1.040, 158.0, 1.063)]
    [InlineData(1.040, 140.0, 1.056)]
    [InlineData(1.040, 122.0, 1.051)]
    [InlineData(1.040, 104.0, 1.047)]
    [InlineData(1.040, 86.0, 1.043)]
    [InlineData(1.040, 68.0, 1.040)]
    public void CalculateFahrenheit(decimal specificGravity, decimal fahrenheitTemperature, decimal expected, decimal fahrenheitCalibrationTemperature = 68.0m)
    {
        // Arrange
        var gravityCalculator = new GravityCalculator();

        // Act
        var result = gravityCalculator.CalculateFahrenheit(specificGravity, fahrenheitTemperature, fahrenheitCalibrationTemperature);

        // Assert
        result.Should()
              .BeApproximately(expected, 0.00099m);
    }
}