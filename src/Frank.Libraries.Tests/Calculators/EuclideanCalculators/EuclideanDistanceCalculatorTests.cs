using FluentAssertions;
using Frank.Libraries.Calculators.EuclideanCalculators;
using Frank.Libraries.Calculators.Types;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Calculators.EuclideanCalculators
{
    public class EuclideanDistanceCalculatorTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public EuclideanDistanceCalculatorTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void TwoDimensionalDistance_ShouldReturnOne()
        {
            // // Arrange
            // var euclideanDistanceCalculator = new EuclideanDistanceCalculator();
            // var origin = new Vector2()
            // {
            //     X = 0.0m,
            //     Y = 0.0m
            // };
            // var destination = new Vector2()
            // {
            //     X = 1.0m,
            //     Y = 0.0m
            // };
            //
            // // Act
            // var result = EuclideanDistanceCalculator.TwoDimensionalDistance(origin, destination);
            //
            // // Assert
            // result.Should().Be(1);
        }

        [Fact]
        public void ThreeDimensionalDistance_ShouldReturnOne()
        {
            // Arrange
            // var euclideanDistanceCalculator = new EuclideanDistanceCalculator();
            // ICartesianCoordinates origin = new Vector3()
            // {
            //     X = 0.0m,
            //     Y = 0.0m,
            //     Z = 0.0m
            // };
            // ICartesianCoordinates destination = new Vector3()
            // {
            //     X = 1.0m,
            //     Y = 0.0m,
            //     Z = 0.0m
            // };
            //
            // // Act
            // var result = EuclideanDistanceCalculator.ThreeDimensionalDistance(origin, destination);
            //
            // // Assert
            // result.Should().Be(1.0m);
        }
    }
}
