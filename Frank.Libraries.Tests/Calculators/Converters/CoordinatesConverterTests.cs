using FluentAssertions;
using Frank.Libraries.Calculators.Converters;
using Frank.Libraries.Calculators.Types;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Calculators.Converters
{
    public class CoordinatesConverterTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public CoordinatesConverterTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void CartesianToSpherical_()
        {
            // Arrange
            ICartesianCoordinates coordinates = new Vector3()
            {
                X = 100.0m,
                Y = 0.0m,
                Z = 0.0m
            };

            // Act
            var result = CoordinatesConverter.CartesianToSpherical(coordinates);

            // Assert
            result.E.Should().BePositive();
        }

        [Fact]
        public void SphericalToCartesian_()
        {
            // Arrange
            IPolarCoordinates polarCoordinates = new PolarCoordinates()
            {
                E = 100.0m,
                P = 0.0m,
                R = 0.0m
            };

            // Act
            var result = CoordinatesConverter.SphericalToCartesian(polarCoordinates);

            // Assert
            Assert.True(false);
        }
    }
}
