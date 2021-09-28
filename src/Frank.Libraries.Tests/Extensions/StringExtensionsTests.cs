using FluentAssertions;
using Frank.Libraries.Extensions;
using Xunit;

namespace Frank.Libraries.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("frank.haugen@gmail.com", true)]
        [InlineData("frank.haugen@g.mail.com", true)]
        [InlineData("frank.haugen@g.ma-il.com", true)]
        [InlineData("frank.haugen@g.ma-il.co", true)]
        [InlineData("frank.haugen@@g.ma-il.com", false)]
        [InlineData("Frank.haugen@g.ma-il.com", false)]
        public void IsEmail(string email, bool expected)
        {
            // Arrange

            // Act
            var result = email.IsEmail();

            // Assert
            result.Should().Be(expected);
        }
    }
}
