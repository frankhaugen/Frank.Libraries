using System.Threading.Tasks;
using FluentAssertions;
using Frank.Libraries.Internet.Wikipedia;
using RestSharp;
using Xunit;

namespace Frank.Libraries.Tests.Internet.Wikipedia
{
    public class WikipediaClientTests
    {
        [Fact]
        public async Task GetSummary_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var wikipediaClient = new WikipediaClient(new RestClient());
            var title = "Norway";

            // Act
            var result = await wikipediaClient.GetSummary(title);

            // Assert
            result.Title.Should().Be("Norway");
        }
    }
}