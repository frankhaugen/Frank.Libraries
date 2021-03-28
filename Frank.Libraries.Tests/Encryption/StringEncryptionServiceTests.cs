using FluentAssertions;
using Frank.Libraries.Security.Encryption;
using Xunit;

namespace Frank.Libraries.Tests.Encryption
{
    public class StringEncryptionServiceTests
    {
        [Fact]
        public void EncryptDecryptString_EncryptsAndDecryptsSuccessfully()
        {
            // Arrange
            var service = new StringEncryptionService();
            string key = "This is a key   ";
            string text = "Password123";

            // Act
            var encryptedString = service.EncryptString(key, text);
            var decryptedString = service.DecryptString(key, encryptedString);

            // Assert
            decryptedString.Should().Be(text);
        }
    }
}