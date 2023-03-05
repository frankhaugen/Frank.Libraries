using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests;

public class TimeServiceTests : TestBase
{
    private readonly IClock subClock;

    public TimeServiceTests(ITestOutputHelper outputHelper) : base(outputHelper) => subClock = new FakeClock(new Instant());

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