using Frank.Libraries.Calculators.FluentCalculation;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;
using NSubstitute;
using Frank.Libraries.Extensions;
using System;
using System;
using System;
using System;
using System;
using System;
using System;
using System;
using System;
using System;

namespace Frank.Libraries.Tests.Calculators.FluentCalculation;

public class FluentCalculatorBasicOperationsTests
{
    private readonly ITestOutputHelper _outputHelper;

    public FluentCalculatorBasicOperationsTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }


    [Fact]
    public async Task AddTest1()
    {
        // Arrange
        var value = default(Int32);
        var source = default(Int32);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task AddTest2()
    {
        // Arrange
        var value = default(Int16);
        var source = default(Int16);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task AddTest3()
    {
        // Arrange
        var value = default(Int64);
        var source = default(Int64);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task AddTest4()
    {
        // Arrange
        var value = default(Single);
        var source = default(Single);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task AddTest5()
    {
        // Arrange
        var value = default(Double);
        var source = default(Double);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task AddTest6()
    {
        // Arrange
        var value = default(Decimal);
        var source = default(Decimal);

        // Act
        var result = source.Add(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task SubtractTest1()
    {
        // Arrange
        var value = default(Int32);
        var source = default(Int32);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task SubtractTest2()
    {
        // Arrange
        var value = default(Int16);
        var source = default(Int16);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task SubtractTest3()
    {
        // Arrange
        var value = default(Int64);
        var source = default(Int64);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task SubtractTest4()
    {
        // Arrange
        var value = default(Single);
        var source = default(Single);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task SubtractTest5()
    {
        // Arrange
        var value = default(Double);
        var source = default(Double);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task SubtractTest6()
    {
        // Arrange
        var value = default(Decimal);
        var source = default(Decimal);

        // Act
        var result = source.Subtract(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task MultiplyTest1()
    {
        // Arrange
        var value = default(Int32);
        var source = default(Int32);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task MultiplyTest2()
    {
        // Arrange
        var value = default(Int16);
        var source = default(Int16);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task MultiplyTest3()
    {
        // Arrange
        var value = default(Int64);
        var source = default(Int64);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task MultiplyTest4()
    {
        // Arrange
        var value = default(Single);
        var source = default(Single);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task MultiplyTest5()
    {
        // Arrange
        var value = default(Double);
        var source = default(Double);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task MultiplyTest6()
    {
        // Arrange
        var value = default(Decimal);
        var source = default(Decimal);

        // Act
        var result = source.Multiply(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task DivideTest1()
    {
        // Arrange
        var value = 5;
        var source = 5;

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task DivideTest2()
    {
        // Arrange
        short value = 5;
        short source = 5;

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task DivideTest3()
    {
        // Arrange
        long value = 5;
        long source = 5;

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task DivideTest4()
    {
        // Arrange
        var value = Single.MinValue;
        var source = Single.MaxValue;

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task DivideTest5()
    {
        // Arrange
        var value = 3.3;
        var source = 9.9;

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task DivideTest6()
    {
        // Arrange
        decimal value = 3.3m;
        decimal source = 9.9m;

        // Act
        var result = source.Divide(value);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }
}
