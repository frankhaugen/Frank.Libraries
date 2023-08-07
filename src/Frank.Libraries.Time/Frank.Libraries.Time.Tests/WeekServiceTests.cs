using NodaTime;
using NodaTime.Testing;
using TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Time.Tests;

public class WeekServiceTests : TestBase
{
    private readonly IClock subClock;

    public WeekServiceTests(ITestOutputHelper outputHelper) : base(outputHelper) => subClock = new FakeClock(new Instant());

    private WeekService CreateService() =>
        new WeekService(
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