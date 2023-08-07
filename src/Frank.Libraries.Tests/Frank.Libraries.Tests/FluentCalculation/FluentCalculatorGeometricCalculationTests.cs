using System.Numerics;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.Calculators.Types;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.FluentCalculation;

public class FluentCalculatorGeometricCalculationTests : TestBase
{
    public FluentCalculatorGeometricCalculationTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Fact]
    public void ToPolar_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var coordinates = new CartesianCoordinates { X = 1, Y = 1, Z = 1 };

        // Act
        var result = coordinates.ToPolar();

        // Assert
        Output(result);
    }

    [Fact]
    public void ToCartesian_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var polarCoordinates = default(PolarCoordinates);

        // Act
        var result = polarCoordinates.ToCartesian();

        // Assert
        Output(result);
    }

    [Fact]
    public void Distance_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var origin = default(Vector2);
        var destination = default(Vector2);

        // Act
        var result = origin.Distance(destination);

        // Assert
        Output(result);
    }

    [Fact]
    public void Distance_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange
        var origin = default(Vector3);
        var destination = default(Vector3);

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
        var origin = default(CartesianCoordinates);
        var destination = default(CartesianCoordinates);

        // Act
        var result = origin.Distance(destination);

        // Assert
        Output(result);
    }

    [Fact]
    public void Distance_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange
        var origin = default(Vector3);
        var destination = default(CartesianCoordinates);

        // Act
        var result = origin.Distance(destination);

        // Assert
        Output(result);
    }

    [Fact]
    public void Distance_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange
        var origin = default(CartesianCoordinates);
        var destination = default(Vector3);

        // Act
        var result = origin.Distance(destination);

        // Assert
        Output(result);
    }
}