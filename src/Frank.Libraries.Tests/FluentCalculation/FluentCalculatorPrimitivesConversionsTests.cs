using FluentAssertions;
using Frank.Libraries.Calculators.FluentCalculation;

namespace Frank.Libraries.Tests.FluentCalculation;

public class FluentCalculatorPrimitivesConversionsTests
{
    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        var source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        uint source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior1()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        short source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        ushort source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior3()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        long source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior4()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        ulong source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior5()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        float source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior6()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDecimal_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        double source = 1;

        // Act
        var result = source.ToDecimal();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToInt_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToInt();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUint_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToUint();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToShort_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToShort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUshort_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToUshort();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToLong_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToLong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToUlong_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToUlong();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToFloat_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToFloat();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }

    [Fact]
    public void ToDouble_StateUnderTest_ExpectedBehavior7()
    {
        // Arrange

        decimal source = 1;

        // Act
        var result = source.ToDouble();

        // Assert
        result.Should()
              .BeGreaterThan(0);
    }
}