using System.Numerics;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.Calculators.Types;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.FluentCalculation
{
    public class FluentCalculatorGeometricCalculationTests : TestBase
    {
        public FluentCalculatorGeometricCalculationTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void ToPolar_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            CartesianCoordinates coordinates = new CartesianCoordinates() { X = 1, Y = 1, Z = 1 };

            // Act
            var result = coordinates.ToPolar();

            // Assert
            Output(result);
        }

        [Fact]
        public void ToCartesian_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            PolarCoordinates polarCoordinates = default(PolarCoordinates);

            // Act
            var result = polarCoordinates.ToCartesian();

            // Assert
            Output(result);
        }

        [Fact]
        public void Distance_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            Vector2 origin = default(Vector2);
            Vector2 destination = default(Vector2);

            // Act
            var result = origin.Distance(destination);

            // Assert
            Output(result);
        }

        [Fact]
        public void Distance_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            Vector3 origin = default(Vector3);
            Vector3 destination = default(Vector3);

            // Act
            var result = origin.Distance(destination);

            // Assert
            Output(result);
            Output(result);
        }

        [Fact]
        public void Distance_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            CartesianCoordinates origin = default(CartesianCoordinates);
            CartesianCoordinates destination = default(CartesianCoordinates);

            // Act
            var result = origin.Distance(destination);

            // Assert
            Output(result);
        }

        [Fact]
        public void Distance_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            Vector3 origin = default(Vector3);
            CartesianCoordinates destination = default(CartesianCoordinates);

            // Act
            var result = origin.Distance(destination);

            // Assert
            Output(result);
        }

        [Fact]
        public void Distance_StateUnderTest_ExpectedBehavior4()
        {
            // Arrange
            CartesianCoordinates origin = default(CartesianCoordinates);
            Vector3 destination = default(Vector3);

            // Act
            var result = origin.Distance(destination);

            // Assert
            Output(result);
        }

    }
}
