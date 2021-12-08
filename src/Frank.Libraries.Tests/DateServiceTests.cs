using System;
using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using NodaTime;
using NodaTime.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class DateServiceTests : TestBase
    {
        private readonly IClock _subClock;

        public DateServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
            this._subClock = new FakeClock(new Instant());
        }

        private DateService CreateService()
        {
            return new DateService(
                this._subClock);
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