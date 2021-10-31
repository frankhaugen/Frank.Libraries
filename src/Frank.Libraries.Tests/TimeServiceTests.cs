using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class TimeServiceTests : TestBase
    {
        private IClock subClock;

        public TimeServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
            this.subClock = new FakeClock(new Instant());
        }

        private TimeService CreateService()
        {
            return new TimeService(
                this.subClock);
        }

        [Fact]
        public void ToString_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.ToString();

            // Assert
            Output(result);
        }
    }
}
