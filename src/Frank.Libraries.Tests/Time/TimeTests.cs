using System;
using FluentAssertions;
using Frank.Libraries.Time;
using NodaTime;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Time
{
    public class TimeTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public TimeTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void GetTimeStringTest()
        {
            // Arrange
            var timeService = new TimeService(SystemClock.Instance);

            // Act
            var result = timeService.ToString();

            // Assert
            _outputHelper.WriteLine(result);
        }

        [Fact]
        public void ActivateAndDeactivateTestmode()
        {
            // Arrange
            var dateTime = new DateTime(1999, 1, 5, 1, 1, 1, 1);
            var time = new Libraries.TimeStuff();

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
