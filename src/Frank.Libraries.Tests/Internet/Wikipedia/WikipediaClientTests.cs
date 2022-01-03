using System.Threading.Tasks;
using FluentAssertions;
using Frank.Libraries.Internet.Wikipedia;
using RestSharp;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Internet.Wikipedia
{
    public class WikipediaClientTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public WikipediaClientTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

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
            _outputHelper.WriteLine(result.Extract);
            _outputHelper.WriteLine("===========================================");
            _outputHelper.WriteLine(result.Lang);
        }
    }
}