using FluentAssertions;
using Frank.Libraries.Brreg;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Frank.Libraries.Tests.Brreg
{
    public class BrregClientTests
    {
        [Fact]
        public async Task GetCompanyAsync_CompanyNamedSemine_ShouldReturnCorrectCompany()
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

        [Fact]
        public async Task GetCompanyAsync_BadOrgNumber_ReturnsArgumentException()
        {
            // Arrange
            var brregClient = new BrregClient();
            long organizationNumber = 0;

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(async () => await brregClient.GetCompanyAsync(organizationNumber));
        }

        [Fact]
        public async Task SearchForLegalEntityAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var brregClient = new BrregClient();
            var companyName = "Semine";
            var town = "";
            var currentPage = 0;
            var pageSize = 100;

            // Act
            var result = await brregClient.SearchForLegalEntityAsync(
                companyName,
                town,
                currentPage,
                pageSize);

            // Assert
            result.Data.Should().NotBeNull();
            result.Data?.Companies.Should().NotBeNullOrEmpty();
            result.Data?.Companies.Should().OnlyHaveUniqueItems();
            result.Links?.Self.Should().NotBeNull();
        }
    }
}
