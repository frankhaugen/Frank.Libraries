using NodaTime;
using NodaTime.Testing;
using Xunit.Abstractions;

namespace Frank.Libraries.Time.Tests;

public class TimeServicesToStringTests
{
    private readonly IClock _clock;
    private readonly ITestOutputHelper _outputHelper;

    public TimeServicesToStringTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _clock = new FakeClock(Instant.FromUtc(2021, 10, 10, 13, 37));
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
    public void DateServiceToString()
    {
        // Arrange
        var service = new DateService(_clock);

        // Act
        var result = service.ToString();

        // Assert
        _outputHelper.WriteLine(result);
    }

    [Fact]
    public void WeekServiceToString()
    {
        // Arrange
        var service = new WeekService(_clock);

        // Act
        var result = service.ToString();

        // Assert
        _outputHelper.WriteLine(result);
    }

    [Fact]
    public void DateTimeServiceToString()
    {
        // Arrange
        var service = new DateTimeService(_clock);

        // Act
        var result = service.ToString();

        // Assert
        _outputHelper.WriteLine(result);
    }

    [Fact]
    public void TimezoneServiceToString()
    {
        // Arrange
        var service = new TimezoneService(_clock);

        // Act
        var result = service.ToString();

        // Assert
        _outputHelper.WriteLine(result);
    }
}