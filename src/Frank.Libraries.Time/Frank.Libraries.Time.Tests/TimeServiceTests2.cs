using NodaTime;
using NodaTime.Testing;
using TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Time.Tests;

public class TimeServiceTests2 : TestBase
{
    private readonly IClock subClock;

    public TimeServiceTests2(ITestOutputHelper outputHelper) : base(outputHelper) => subClock = new FakeClock(new Instant());

    private TimeService CreateService() =>
        new TimeService(
            subClock);

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