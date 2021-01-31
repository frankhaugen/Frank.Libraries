using System;
using System.Collections.Generic;
using FluentAssertions;
using Frank.Libraries.Security;
using Frank.Libraries.Security.Shared;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Security
{
    public class PasswordGeneratorTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PasswordGeneratorTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void GenerateManyPasswords_AllToBeUnique()
        {
            // Arrange
            var passwordGenerator = new PasswordGenerator();
            var passwordCount = 1000;

            // Act
            var resultList = new List<string>();
            for (var i = 0; i < passwordCount; i++)
            {
                resultList.Add(passwordGenerator.GeneratePassword());
            }

            // Assert
            resultList.Should().OnlyHaveUniqueItems();
        }

        [Fact]
        public void GeneratePassword_NoVariantsSupplied_ThrowNullReferenceException()
        {
            // Arrange
            var passwordGenerator = new PasswordGenerator();
            var characterCount = 10;
            CharacterVariant[] characterVariants = null!;

            // Act and Assert
            Assert.Throws<NullReferenceException>(() => passwordGenerator.GeneratePassword(characterCount, characterVariants));
        }

        [Fact]
        public void GeneratePassword_NonPositiveCountSupplied_ThrowArgumentException()
        {
            // Arrange
            var passwordGenerator = new PasswordGenerator();
            var characterCount = 0;
            CharacterVariant[] characterVariants = new[] { CharacterVariant.Lowercase, CharacterVariant.Special };

            // Act and Assert
            Assert.Throws<ArgumentException>(() => passwordGenerator.GeneratePassword(characterCount, characterVariants));
        }

        [Fact]
        public void GeneratePassword()
        {
            // Arrange
            var passwordGenerator = new PasswordGenerator();
            var characterCount = 10;
            CharacterVariant[] characterVariants = new[] { CharacterVariant.Lowercase, CharacterVariant.Special };

            // Act and Assert
            passwordGenerator.GeneratePassword(characterCount, characterVariants);
        }

        [Fact]
        public void GeneratePassword_DefaultSettings_ReturnNewPassword()
        {
            // Arrange
            var passwordGenerator = new PasswordGenerator();

            // Act
            var result = passwordGenerator.GeneratePassword();

            // Assert
            result.Should().HaveLength(12);
        }

        [Fact]
        public void GeneratePassword_TenCharactersLong_ShouldBeTenCharacters()
        {
            // Arrange
            var passwordGenerator = new PasswordGenerator();
            var characterCount = 10;

            // Act
            var result = passwordGenerator.GeneratePassword(characterCount);

            // Assert
            result.Should().HaveLength(characterCount);
            _outputHelper.WriteLine(result);
        }
    }
}
