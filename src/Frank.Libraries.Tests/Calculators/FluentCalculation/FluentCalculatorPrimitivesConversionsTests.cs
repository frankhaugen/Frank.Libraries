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
using System;
using System;
using System;

namespace Frank.Libraries.Tests.Calculators.FluentCalculation;
 
public class FluentCalculatorPrimitivesConversionsTests
{
    private readonly ITestOutputHelper _outputHelper;

    public FluentCalculatorPrimitivesConversionsTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }


    [Fact]
    public async Task ToUintTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUintTest2()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUintTest3()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUintTest4()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUintTest5()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUintTest6()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUintTest7()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUintTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToUint();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest2()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest3()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest4()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest5()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest6()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest7()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToShortTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToShort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest2()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest3()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest4()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest5()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest6()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest7()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUshortTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToUshort();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest2()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest3()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest4()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest5()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest6()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest7()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToLongTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToLong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest2()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest3()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest4()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest5()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest6()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest7()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToUlongTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToUlong();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest2()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest3()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest4()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest5()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest6()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest7()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToFloatTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToFloat();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest2()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest3()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest4()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest5()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest6()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest7()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDoubleTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToDouble();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest1()
    {
        // Arrange
        var source = default(Int32);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest2()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest3()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest4()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest5()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest6()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest7()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToDecimalTest8()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToDecimal();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest1()
    {
        // Arrange
        var source = default(UInt32);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest2()
    {
        // Arrange
        var source = default(Int16);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest3()
    {
        // Arrange
        var source = default(UInt16);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest4()
    {
        // Arrange
        var source = default(Int64);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest5()
    {
        // Arrange
        var source = default(UInt64);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest6()
    {
        // Arrange
        var source = default(Single);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest7()
    {
        // Arrange
        var source = default(Double);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ToIntTest8()
    {
        // Arrange
        var source = default(Decimal);

        // Act
        var result = source.ToInt();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }
}
