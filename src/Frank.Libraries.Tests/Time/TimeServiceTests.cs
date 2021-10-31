using FluentAssertions;
using Frank.Libraries.Enums.Countries;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Time
{
    public class TimeServiceTests
    {
        private readonly IClock _clock;
        private readonly ITestOutputHelper _outputHelper;

        private const int Year = 2021;
        private const int Month = 10;
        private const int Day = 10;
        private const int Hour = 13;
        private const int Minute = 37;


        public TimeServiceTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _clock = new FakeClock(Instant.FromUtc(Year, Month, Day, Hour, Minute));
        }

        [Fact]
        public void TimeServiceToString()
        {
            // Arrange
            var service = new TimeService(_clock);

            // Act
            var result = service.ToString();

            // Assert
            _outputHelper.WriteLine(result);
        }

        [Fact]
        public void TimeService_Hours()
        {
            // Arrange
            var service = new TimeService(_clock);

            // Act
            var result = service.Hours;

            // Assert
            result.Should().Be(Hour);
            _outputHelper.WriteLine(result.ToString());
        }

        [Fact]
        public void TimeService_Minutes()
        {
            // Arrange
            var service = new TimeService(_clock);

            // Act
            var result = service.Minutes;

            // Assert
            result.Should().Be(Minute);
            _outputHelper.WriteLine(result.ToString());
        }
    }
}
