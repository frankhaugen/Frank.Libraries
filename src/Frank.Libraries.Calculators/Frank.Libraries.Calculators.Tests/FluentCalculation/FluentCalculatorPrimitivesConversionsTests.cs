using FluentAssertions;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.Extensions;
using Xunit.Abstractions;

namespace Frank.Libraries.Calculators.Tests.FluentCalculation;

public class FluentCalculatorPrimitivesConversionsTests
{
    private readonly ITestOutputHelper _outputHelper;

    public FluentCalculatorPrimitivesConversionsTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void ToUintTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUintTest2()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUintTest3()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUintTest4()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUintTest5()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUintTest6()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUintTest7()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUintTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest2()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest3()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest4()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest5()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest6()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest7()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToShortTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest2()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest3()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest4()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest5()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest6()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest7()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUshortTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest2()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest3()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest4()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest5()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest6()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest7()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToLongTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest2()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest3()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest4()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest5()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest6()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest7()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToUlongTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest2()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest3()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest4()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest5()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest6()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest7()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToFloatTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest2()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest3()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest4()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest5()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest6()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest7()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDoubleTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest1()
    {
        // Arrange
        var source = default(int);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest2()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest3()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest4()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest5()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest6()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest7()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToDecimalTest8()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest1()
    {
        // Arrange
        var source = default(uint);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest2()
    {
        // Arrange
        var source = default(short);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest3()
    {
        // Arrange
        var source = default(ushort);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest4()
    {
        // Arrange
        var source = default(long);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest5()
    {
        // Arrange
        var source = default(ulong);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest6()
    {
        // Arrange
        var source = default(float);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest7()
    {
        // Arrange
        var source = default(double);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }

    [Fact]
    public void ToIntTest8()
    {
        // Arrange
        var source = default(decimal);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString()
              .Should()
              .NotBeNullOrEmpty();
    }
}