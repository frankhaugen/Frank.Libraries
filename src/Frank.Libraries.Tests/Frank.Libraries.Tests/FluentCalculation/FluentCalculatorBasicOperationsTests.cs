using FluentAssertions;
using Frank.Libraries.Calculators.FluentCalculation;

namespace Frank.Libraries.Tests.FluentCalculation;

public class FluentCalculatorBasicOperationsTests
{
    [Fact]
    public void Add_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;
        var value = 1;

        // Act
        var result = source.Add(value);

        // Assert
        result.Should()
              .BeGreaterThan(1);
    }

    [Fact]
    public void Add_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        short source = 1;
        short value = 1;

        // Act
        var result = source.Add(value);

        // Assert
        result.Should()
              .BeGreaterThan(1);
    }

    [Fact]
    public void Add_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        long source = 1;
        long value = 1;

        // Act
        var result = source.Add(value);

        // Assert
        result.Should()
              .BeGreaterThan(1);
    }

    [Fact]
    public void Add_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange
        float source = 1;
        float value = 1;

        // Act
        var result = source.Add(value);

        // Assert
        result.Should()
              .BeGreaterThan(1);
    }

    [Fact]
    public void Add_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange
        double source = 1;
        double value = 1;

        // Act
        var result = source.Add(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Add_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        decimal source = 1;
        decimal value = 1;

        // Act
        var result = source.Add(value);

        // Assert
        result.Should()
              .BeGreaterThan(1);
    }

    [Fact]
    public void Subtract_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var source = 1;
        var value = 1;

        // Act
        var result = source.Subtract(value);

        // Assert
        result.Should()
              .BeLessThanOrEqualTo(1);
    }

    [Fact]
    public void Subtract_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        short source = 1;
        short value = 1;

        // Act
        var result = source.Subtract(value);

        // Assert
        result.Should()
              .BeLessThanOrEqualTo(1);
    }

    [Fact]
    public void Subtract_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        long source = 1;
        long value = 1;

        // Act
        var result = source.Subtract(value);

        // Assert
        result.Should()
              .BeLessThanOrEqualTo(1);
    }

    [Fact]
    public void Subtract_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        float source = 1;
        float value = 1;

        // Act
        var result = source.Subtract(value);

        // Assert
        result.Should()
              .BeLessThanOrEqualTo(1);
    }

    [Fact]
    public void Subtract_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        double source = 1;
        double value = 1;

        // Act
        var result = source.Subtract(value);

        // Assert
        result.Should()
              .BeLessThanOrEqualTo(1);
    }

    [Fact]
    public void Subtract_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        decimal source = 1;
        decimal value = 1;

        // Act
        var result = source.Subtract(value);

        // Assert
        result.Should()
              .BeLessThanOrEqualTo(1);
    }

    [Fact]
    public void Multiply_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;
        var value = 1;

        // Act
        var result = source.Multiply(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Multiply_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        short source = 1;
        short value = 1;

        // Act
        var result = source.Multiply(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Multiply_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        long source = 1;
        long value = 1;

        // Act
        var result = source.Multiply(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Multiply_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        float source = 1;
        float value = 1;

        // Act
        var result = source.Multiply(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Multiply_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        double source = 1;
        double value = 1;

        // Act
        var result = source.Multiply(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Multiply_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        decimal source = 1;
        decimal value = 1;

        // Act
        var result = source.Multiply(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Divide_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;
        var value = 1;

        // Act
        var result = source.Divide(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Divide_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        short source = 1;
        short value = 1;

        // Act
        var result = source.Divide(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Divide_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        long source = 1;
        long value = 1;

        // Act
        var result = source.Divide(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Divide_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        float source = 1;
        float value = 1;

        // Act
        var result = source.Divide(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Divide_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        double source = 1;
        double value = 1;

        // Act
        var result = source.Divide(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }

    [Fact]
    public void Divide_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        decimal source = 1;
        decimal value = 1;

        // Act
        var result = source.Divide(value);

        // Assert
        result.Should()
              .BeGreaterThanOrEqualTo(1);
    }
}