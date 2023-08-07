using NodaTime;
using NodaTime.Testing;
using TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Time.Tests;

public class DateTimeServiceTests : TestBase
{
    private readonly IClock subClock;

    public DateTimeServiceTests(ITestOutputHelper outputHelper) : base(outputHelper) => subClock = new FakeClock(new Instant());

    private DateTimeService CreateService() =>
        new DateTimeService(
            subClock);

    [Fact]
    public void Instant_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();

        // Act
        var result = service.Instant();

        // Assert
        Output(result);
    }

    [Fact]
    public void DateTime_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();

        // Act
        var result = service.DateTime();

        // Assert
        Output(result);
    }

    [Fact]
    public void DateTimeOffset_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();

        // Act
        var result = service.DateTimeOffset();

        // Assert
        Output(result);
    }

    [Fact]
    public void TimeOfDay_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();

        // Act
        var result = service.TimeOfDay();

        // Assert
        Output(result);
    }

    //[Fact]
    public void ZonedDateTime_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();
        var ianaTimezone = "europe/oslo";

        // Act
        var result = service.ZonedDateTime(
            ianaTimezone);

        // Assert
        Output(result);
    }

    [Fact]
    public void UtcDateTime_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();

        // Act
        var result = service.UtcDateTime();

        // Assert
        Output(result);
    }

    [Fact]
    public void ToString_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var service = CreateService();

        // Act
        var result = service.ToString();

        // Assert
        Output(result);
    }
}