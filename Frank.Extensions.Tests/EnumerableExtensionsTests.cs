using AutoFixture;
using FluentAssertions;
using Frank.Extensions.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Frank.Extensions.Tests
{
    public class EnumerableExtensionsTests
    {
        private readonly Fixture _fixture = new Fixture();

        private readonly IEnumerable<string> _things;

        public EnumerableExtensionsTests()
        {
            _things = _fixture.CreateMany<string>(100);
        }

        [Fact]
        public void Batch_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var maxItems = 10;

            // Act
            var result = _things.Batch(maxItems);

            // Assert
            result.Should().HaveCount(10);
        }

        [Fact]
        public void Random_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var results = new List<bool>();

            // Act
            for (int i = 0; i < 1024; i++)
            {
                var result = _things.Random();

                results.Add(_things.Contains(result));
            }

            // Assert
            results.Should().AllBeEquivalentTo(true);
        }
    }
}