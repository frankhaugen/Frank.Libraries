using System;
using FluentAssertions;
using Xunit;

namespace Frank.Libraries.Tests.Time
{
    public class TimeTests
    {
        [Fact]
        public void ActivateAndDeactivateTestmode()
        {
            // Arrange
            var dateTime = new DateTime(1999, 1, 5, 1, 1, 1, 1);
            var time = new Libraries.Time();

            // Act
            time.StartTestMode();
            time.SetTestTime(dateTime.ToWeekTime());

            // Assert
            time.Now.Should().Be(dateTime.ToWeekTime());
            time.StopTestMode();
            time.Now.ToDateTime().Should().NotBeCloseTo(dateTime, TimeSpan.FromMinutes(1.0));
        }
    }
}
