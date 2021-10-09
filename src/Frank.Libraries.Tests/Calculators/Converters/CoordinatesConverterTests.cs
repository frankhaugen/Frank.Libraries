using FluentAssertions;
using Frank.Libraries.Calculators.Converters;
using Frank.Libraries.Calculators.FluentCalculation;
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
            var coordinates = new CartesianCoordinates()
            {
                X = (decimal)100.0,
                Y = (decimal)100.0,
                Z = (decimal)100.0
            };

            // Act
            var result = coordinates.ToPolar();
            var result2 = result.ToCartesian();

            // Assert
            result2.X.Should().BeApproximately(coordinates.X, 0.05m);
            result2.Y.Should().BeApproximately(coordinates.Y, 0.05m);
            result2.Z.Should().BeApproximately(coordinates.Z, 0.05m);
            result.Inclination.Should().BeApproximately(0.9553166181245092781638571022m, 0.05m);
            result.Azimuth.Should().BeApproximately(0.7853981633974483096156608458m, 0.05m);
            result.Radius.Should().BeApproximately(173.20508075688772935274463415m, 0.05m);
        }

        [Fact]
        public void SphericalToCartesian_()
        {
            // Arrange
            var polarCoordinates = new PolarCoordinates()
            {
                Azimuth = 0.7853981633974483096156608458m,
                Inclination = 0.9553166181245092781638571022m,
                Radius = 173.20508075688772935274463415m
            };

            // Act
            var result = CoordinatesConverter.SphericalToCartesian(polarCoordinates);
            var result2 = CoordinatesConverter.CartesianToSpherical(result);

            // Assert
            result.X.Should().BeApproximately(100m, 0.05m);
            result.Y.Should().BeApproximately(100m, 0.05m);
            result.Z.Should().BeApproximately(100m, 0.05m);
            result2.Inclination.Should().BeApproximately(polarCoordinates.Inclination, 0.05m);
            result2.Azimuth.Should().BeApproximately(polarCoordinates.Azimuth, 0.05m);
            result2.Radius.Should().BeApproximately(polarCoordinates.Radius, 0.05m);
        }
    }
}