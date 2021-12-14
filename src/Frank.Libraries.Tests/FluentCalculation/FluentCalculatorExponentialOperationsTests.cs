using FluentAssertions;
using Frank.Libraries.Calculators.FluentCalculation;
using Frank.Libraries.Tests.TestingInfrastructure;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.FluentCalculation
{
    public class FluentCalculatorExponentialOperationsTests : TestBase
    {
        [Theory]
        [InlineData(3, 2, 9)]
        [InlineData(2, 4, 16)]
        public void Pow_StateUnderTest_ExpectedBehavior(int source, int value, int expected)
        {
            // Arrange

            // Act
            var result = source.Pow(value);

            // Assert
            result.Should()
                  .Be(expected);
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var source = 9;

            // Act
            var result = source.Sqrt();

            // Assert
            result.Should()
                  .Be(3);
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            uint source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            uint source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            short source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            short source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            ushort source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            ushort source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior4()
        {
            // Arrange
            long source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior4()
        {
            // Arrange
            long source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior5()
        {
            // Arrange
            ulong source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior5()
        {
            // Arrange
            ulong source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior6()
        {
            // Arrange
            float source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior6()
        {
            // Arrange
            float source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior7()
        {
            // Arrange
            double source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior7()
        {
            // Arrange
            double source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        [Fact]
        public void Pow_StateUnderTest_ExpectedBehavior8()
        {
            // Arrange
            decimal source = 0;
            var value = 0;

            // Act
            var result = source.Pow(value);

            // Assert
            Output(result);
        }

        [Fact]
        public void Sqrt_StateUnderTest_ExpectedBehavior8()
        {
            // Arrange
            decimal source = 0;

            // Act
            var result = source.Sqrt();

            // Assert
            Output(result);
        }

        public FluentCalculatorExponentialOperationsTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
    }
}