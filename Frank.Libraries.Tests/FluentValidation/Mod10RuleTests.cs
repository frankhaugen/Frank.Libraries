using FluentAssertions;
using FluentValidation;
using Frank.Libraries.FluentValidation;
using Xunit;

namespace Frank.Libraries.Tests.FluentValidation
{
    public class Mod10RuleTests
    {
        [Fact]
        public void IsMod10_Short_True()
        {
            // Arrange
            var validator = new Mod10ShortValidator();
            short number = 14;

            // Act
            var result = validator.Validate(number);

            // Assert
            result.Errors.Should().BeEmpty();
            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void IsMod10_Long_True()
        {
            // Arrange
            var validator = new Mod10LongValidator();
            var number = 502114008060;

            // Act
            var result = validator.Validate(number);

            // Assert
            result.Errors.Should().BeEmpty();
            result.IsValid.Should().BeTrue();
        }

        [Theory]
        //[InlineData("14", 5, true)]
        //[InlineData("1", 0, false)]
        [InlineData("502114008060", 8, true)]
        public void GetMod10_StateUnderTest_ExpectedBehavior(string value, int expectedControlNumber, bool expectedValidity)
        {
            // Arrange

            // Act
            var result = Mod10Rule.GetMod10(value);

            // Assert
            result.Should().NotBeNull();
            result.ControlNumber.Should().Be(expectedControlNumber);
            result.IsValid.Should().Be(expectedValidity);
        }
    }
}