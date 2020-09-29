using System;
using FluentAssertions;
using Frank.Libraries.Security;
using Xunit;

namespace Frank.Libraries.Tests.Security
{
    public class PasswordHasherTests
    {
        [Fact]
        public void HashPassword()
        {
            // Arrange
            var passwordHasher = new PasswordHasher();
            var password = Guid.NewGuid().ToString();

            // Act
            var result = passwordHasher.HashPassword(password);

            // Assert
            result.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void CheckPasswordAgainstHash()
        {
            // Arrange
            var passwordHasher = new PasswordHasher();
            var password = Guid.NewGuid().ToString();
            var hashedPassword = passwordHasher.HashPassword(password);

            // Act
            var result = passwordHasher.CheckPasswordAgainstHash(password, hashedPassword);

            // Assert
            result.Should().BeTrue();
        }
    }
}
