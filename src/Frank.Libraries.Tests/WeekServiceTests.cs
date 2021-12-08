using Frank.Libraries.Json;
using Frank.Libraries.Tests.TestingInfrastructure;
using Frank.Libraries.Time;
using Frank.Libraries.Xml;
using NodaTime;
using NodaTime.Testing;
using RestSharp;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class WeekServiceTests : TestBase
    {
        private IClock subClock;

        public WeekServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
            this.subClock = new FakeClock(new Instant());
        }

        private WeekService CreateService()
        {
            return new WeekService(
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

        [Fact]
        public void TestThingy()
        {
            // Arrange
            var client = new RestClient("https://www.vg.no");
            var request = new RestRequest("/segments/{Segment2}", Method.GET);

            // Act
            request.AddUrlSegment("Segment1", "FirstSegment");
            request.AddUrlSegment("Segment2", "SecondSegment");

            var result = client.Execute(request);

            // Assert
            Output(result.ResponseUri);
        }


    }
}