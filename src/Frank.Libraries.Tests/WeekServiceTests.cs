using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests;

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