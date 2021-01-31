using System.Threading.Tasks;
using FluentAssertions;
using Frank.Libraries.Currency;
using Frank.Libraries.Json;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class CurrencyClientTests
    {
        private readonly ITestOutputHelper _outputHelper;
        private readonly CurrencyClient _currencyClient;

        public CurrencyClientTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _currencyClient = new CurrencyClient();
        }

        [Fact]
        public async Task GetLatestRates_UsingDefaults_ShouldSucceed()
        {
            // Act
            var result = await _currencyClient.GetLatestRates();

            // Assert
            result.Should().NotBeNull();
            result.Success.Should().BeTrue();
            _outputHelper.WriteLine(result.ToJson());
        }

        //[Fact]
        public async Task Convert_UsingDefaults_ShouldReturnOne()
        {
            // Act
            var result = await _currencyClient.Convert();

            // Assert
            result.Should().Be(1);
        }
    }
}
