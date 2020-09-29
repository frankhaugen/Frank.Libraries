using AutoBogus;
using Bogus;
using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using System.Collections.Generic;
using Xunit;

namespace Frank.Libraries.Tests.Extensions
{
    public class EnumerableExtensionsTests
    {
        private readonly Faker _faker;

        //private readonly IEnumerable<string> _things;

        public EnumerableExtensionsTests()
        {
            _faker = new Faker();
            //_things = _fixture.CreateMany<string>(100);
        }

        [Fact]
        public void Batch_ReturnsCorrectCount()
        {
            // Arrange
            var items = CreateTestModels(100);
            var maxItems = 10;

            // Act
            var result = items.Batch(maxItems);

            // Assert
            result.Should().HaveCount(10);
        }

        [Fact]
        public void Random_ReturnsRandomItem()
        {
            // Arrange
            var items = CreateTestModels();

            // Act
            var result = items.Random();

            // Assert
            items.Should().Contain(result);
        }

        //[Fact]
        //public void Random()
        //{
        //    // Arrange
        //    var items = CreateTestModels();

        //    // Act
        //    var result = items.Pivot<>();

        //    // Assert
        //    results.Should().AllBeEquivalentTo(true);
        //}

        private TestDocument CreateTestModel() => new AutoFaker<TestDocument>().Generate();
        private List<TestDocument> CreateTestModels(int count = 10) => new AutoFaker<TestDocument>().Generate(count);
    }
}
