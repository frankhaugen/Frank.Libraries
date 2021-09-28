using System;
using FluentAssertions;
using Xunit;

namespace Frank.Libraries.Tests.Time
{
    public class WeekTimeExtensionsTests
    {
        [Fact]
        public void ToDateTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var now = DateTime.UtcNow;
            var weekTime = new WeekTime(now);

            // Act
            var result = weekTime.ToDateTime();

            // Assert
            result.Should().BeCloseTo(now, TimeSpan.FromMilliseconds(1.0));
        }

        [Fact]
        public void ToDayOfYear_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var weekTime = WeekTime.Now;

            // Act
            var result = weekTime.ToDayOfYear();

            // Assert
            result.Should().Be(DateTime.UtcNow.DayOfYear);
        }
    }
}
