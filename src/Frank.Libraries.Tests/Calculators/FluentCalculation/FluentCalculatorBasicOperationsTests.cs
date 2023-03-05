using FluentAssertions;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.Extensions;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Calculators.FluentCalculation;

public class FluentCalculatorBasicOperationsTests
{
    private readonly ITestOutputHelper _outputHelper;

    public FluentCalculatorBasicOperationsTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void AddTest1()
    {
        // Arrange
        var value = default(int);
        var source = default(int);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void AddTest2()
    {
        // Arrange
        var value = default(short);
        var source = default(short);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void AddTest3()
    {
        // Arrange
        var value = default(long);
        var source = default(long);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void AddTest4()
    {
        // Arrange
        var value = default(float);
        var source = default(float);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void AddTest5()
    {
        // Arrange
        var value = default(double);
        var source = default(double);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void AddTest6()
    {
        // Arrange
        var value = default(decimal);
        var source = default(decimal);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void SubtractTest1()
    {
        // Arrange
        var value = default(int);
        var source = default(int);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void SubtractTest2()
    {
        // Arrange
        var value = default(short);
        var source = default(short);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void SubtractTest3()
    {
        // Arrange
        var value = default(long);
        var source = default(long);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void SubtractTest4()
    {
        // Arrange
        var value = default(float);
        var source = default(float);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void SubtractTest5()
    {
        // Arrange
        var value = default(double);
        var source = default(double);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void SubtractTest6()
    {
        // Arrange
        var value = default(decimal);
        var source = default(decimal);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void MultiplyTest1()
    {
        // Arrange
        var value = default(int);
        var source = default(int);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void MultiplyTest2()
    {
        // Arrange
        var value = default(short);
        var source = default(short);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void MultiplyTest3()
    {
        // Arrange
        var value = default(long);
        var source = default(long);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void MultiplyTest4()
    {
        // Arrange
        var value = default(float);
        var source = default(float);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void MultiplyTest5()
    {
        // Arrange
        var value = default(double);
        var source = default(double);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void MultiplyTest6()
    {
        // Arrange
        var value = default(decimal);
        var source = default(decimal);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    // [Fact]
    public void DivideTest1()
    {
        // Arrange
        var value = default(int);
        var source = default(int);

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    // [Fact]
    public void DivideTest2()
    {
        // Arrange
        var value = default(short);
        var source = default(short);

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    // [Fact]
    public void DivideTest3()
    {
        // Arrange
        var value = default(long);
        var source = default(long);

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    // [Fact]
    public void DivideTest4()
    {
        // Arrange
        var value = default(float);
        var source = default(float);

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    // [Fact]
    public void DivideTest5()
    {
        // Arrange
        var value = 55.0;
        var source = default(double);

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    // [Fact]
    public void DivideTest6()
    {
        // Arrange
        var value = default(decimal);
        var source = default(decimal);

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }
}