using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class DateTimeServiceTests : TestBase
    {
        private IClock subClock;

        public DateTimeServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
            this.subClock = new FakeClock(new Instant());
        }

        private DateTimeService CreateService()
        {
            return new DateTimeService(
                this.subClock);
        }

        [Fact]
        public void Instant_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.Instant();

            // Assert
            Output(result);
        }

        [Fact]
        public void DateTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.DateTime();

            // Assert
            Output(result);
        }

        [Fact]
        public void DateTimeOffset_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.DateTimeOffset();

            // Assert
            Output(result);
        }

        [Fact]
        public void TimeOfDay_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.TimeOfDay();

            // Assert
            Output(result);
        }

        //[Fact]
        public void ZonedDateTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ianaTimezone = "europe/oslo";

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
            var service = this.CreateService();

            // Act
            var result = service.UtcDateTime();

            // Assert
            Output(result);
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