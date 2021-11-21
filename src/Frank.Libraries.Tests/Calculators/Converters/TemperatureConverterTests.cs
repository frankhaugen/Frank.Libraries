using FluentAssertions;
using Frank.Libraries.Calculators.Converters;
using Xunit;

namespace Frank.Libraries.Tests.Calculators.Converters
{
    public class TemperatureConverterTests
    {
        [Theory]
        [InlineData(32.0, 0.0)]
        [InlineData(212.0, 100.0)]
        [InlineData(-40.0, -40.0)]
        public void FahrenheitToCelsius(decimal temperature, decimal expected)
        {
            // Arrange
            var temperatureConverter = new TemperatureConverter();

            // Act
            var result = TemperatureConverter.FahrenheitToCelsius(temperature);

            // Assert
            result.Should()
                  .Be(expected);
        }

        [Theory]
        [InlineData(0.0, 32.0)]
        [InlineData(100.0, 212.0)]
        [InlineData(-40.0, -40.0)]
        public void CelsiusToFahrenheit(decimal temperature, decimal expected)
        {
            // Arrange
            var temperatureConverter = new TemperatureConverter();

            // Act
            var result = TemperatureConverter.CelsiusToFahrenheit(temperature);

            // Assert
            result.Should()
                  .Be(expected);
        }

        [Theory]
        [InlineData(-273.15, 0.0)]
        [InlineData(100.0, 373.15)]
        [InlineData(-40.0, 233.15)]
        public void CelsiusToKelvin(decimal temperature, decimal expected)
        {
            // Arrange
            var temperatureConverter = new TemperatureConverter();

            // Act
            var result = TemperatureConverter.CelsiusToKelvin(temperature);

            // Assert
            result.Should()
                  .Be(expected);
        }

        [Theory]
        [InlineData(0.0, -273.15)]
        [InlineData(373.15, 100.0)]
        [InlineData(233.15, -40.0)]
        public void KelvinToCelsius(decimal temperature, decimal expected)
        {
            // Arrange
            var temperatureConverter = new TemperatureConverter();

            // Act
            var result = TemperatureConverter.KelvinToCelsius(temperature);

            // Assert
            result.Should()
                  .Be(expected);
        }

        [Theory]
        [InlineData(32, 273.15)]
        [InlineData(212.0, 373.15)]
        [InlineData(-40.0, 233.15)]
        public void FahrenheitToKelvin(decimal temperature, decimal expected)
        {
            // Arrange
            var temperatureConverter = new TemperatureConverter();

            // Act
            var result = TemperatureConverter.FahrenheitToKelvin(temperature);

            // Assert
            result.Should()
                  .Be(expected);
        }

        [Theory]
        [InlineData(273.15, 32)]
        [InlineData(373.15, 212.0)]
        [InlineData(233.15, -40.0)]
        public void KelvinToFahrenheit(decimal temperature, decimal expected)
        {
            // Arrange
            var temperatureConverter = new TemperatureConverter();

            // Act
            var result = TemperatureConverter.KelvinToFahrenheit(temperature);

            // Assert
            result.Should()
                  .Be(expected);
        }
    }
}