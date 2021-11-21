using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class TimezoneServiceTests : TestBase
    {
        private IClock subClock;

        public TimezoneServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
            this.subClock = new FakeClock(new Instant());
        }

        private TimezoneService CreateService()
        {
            return new TimezoneService(
                this.subClock);
        }

        [Fact]
        public void GetTimezones_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.GetTimezones();

            // Assert
            Output(result);
        }

        [Fact]
        public void GetTimezones_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var service = this.CreateService();
            Offset offset = default(global::NodaTime.Offset);

            // Act
            var result = service.GetTimezones(
                offset);

            // Assert
            Output(result);
        }

        [Fact]
        public void GetTimezoneNames_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.GetTimezoneNames();

            // Assert
            Output(result);
        }

        [Fact]
        public void GetSystemTimezone_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.GetSystemTimezone();

            // Assert
            Output(result);
        }

        //[Fact]
        public void ParseTimezone_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ianaName = "europe-oslo";

            // Act
            var result = service.ParseTimezone(
                ianaName);

            // Assert
            Output(result);
        }

        [Fact]
        public void TimezoneExist_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ianaName = "europe/oslo";

            // Act
            var result = service.TimezoneExist(
                ianaName);

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