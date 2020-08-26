using System.Threading.Tasks;
using FluentAssertions;
using Frank.Libraries.Brreg;
using Xunit;

namespace Frank.Libraries.Tests.Brreg
{
    public class BrregClientTests
    {
        [Fact]
        public async Task GetCompanyAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var brregClient = new BrregClient();
            var organizationNumber = 915085865;

            // Act
            var result = await brregClient.GetCompanyAsync(organizationNumber);

            // Assert
            result.Navn.Should().NotBeNullOrWhiteSpace();
            result.Navn.ToLowerInvariant().Should().Contain("semine");
        }
    }
}
