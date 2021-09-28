﻿using FluentAssertions;
using Frank.Libraries.Security.Encryption;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Encryption
{
    public class StringEncryptionServiceTests : TestBase
    {
        public StringEncryptionServiceTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void EncryptDecryptString_EncryptsAndDecryptsSuccessfully()
        {
            // Arrange
            var service = new StringEncryptionService();
            string key = "This is a key111";
            string text = "Password123";

            // Act
            //var encryptedString = service.EncryptString(key, text);
            var encryptedString = StringEncryptionService.Encrypt(key, text);
            Output(encryptedString);

            //var decryptedString = service.DecryptString(key, encryptedString);
            var decryptedString = StringEncryptionService.Decrypt(key, encryptedString);
            Output(decryptedString);

            // Assert
            decryptedString.Should().Be(text);
        }
    }
}