using FluentAssertions;
using Frank.Libraries.Calculators.FluentCalculation;
using Xunit;

namespace Frank.Libraries.Tests.FluentCalculation
{
    public class FluentCalculatorTests
    {
        [Fact]
        public void Chain_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var source = 0;

            // Act
            var result = source.Add(10).Multiply(10).Divide(4).Add(25).Add(100).Subtract(50);

            // Assert
            result.Should().Be(100);
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var source = 1;
            var value = 99;

            // Act
            var result = source.Add(value);

            // Assert
            result.Should().Be(100);
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            decimal source = 10;
            decimal value = 90;

            // Act
            var result = source.Add(value);

            // Assert
            result.Should().Be(100);
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var source = 49.5;
            var value = 50.5;

            // Act
            var result = source.Add(value);

            // Assert
            result.Should().Be(100);
        }

        [Fact]
        public void Subtract_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var source = 200;
            var value = 100;

            // Act
            var result = source.Subtract(value);

            // Assert
            result.Should().Be(100);
        }

        //[Fact]
        //public void Subtract_StateUnderTest_ExpectedBehavior1()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    decimal source = 0;
        //    decimal value = 0;

        // // Act var result = fluentCalculator.Subtract( source, value);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void Subtract_StateUnderTest_ExpectedBehavior2()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    double source = 0;
        //    double value = 0;

        // // Act var result = fluentCalculator.Subtract( source, value);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void Multiply_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    int source = 0;
        //    int value = 0;

        // // Act var result = fluentCalculator.Multiply( source, value);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void Multiply_StateUnderTest_ExpectedBehavior1()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    decimal source = 0;
        //    decimal value = 0;

        // // Act var result = fluentCalculator.Multiply( source, value);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void Multiply_StateUnderTest_ExpectedBehavior2()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    double source = 0;
        //    double value = 0;

        // // Act var result = fluentCalculator.Multiply( source, value);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void Divide_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    int source = 0;
        //    int value = 0;

        // // Act var result = fluentCalculator.Divide( source, value);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void Divide_StateUnderTest_ExpectedBehavior1()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    decimal source = 0;
        //    decimal value = 0;

        // // Act var result = fluentCalculator.Divide( source, value);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void Divide_StateUnderTest_ExpectedBehavior2()
        //{
        //    // Arrange
        //    var fluentCalculator = new FluentCalculator();
        //    double source = 0;
        //    double value = 0;

        // // Act var result = fluentCalculator.Divide( source, value);

        //    // Assert
        //    Assert.True(false);
        //}
    }
}