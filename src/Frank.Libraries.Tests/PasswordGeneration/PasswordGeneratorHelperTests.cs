using System;
using System.Collections.Generic;
using FluentAssertions;
using Frank.Libraries.Security.PasswordGeneration;
using Frank.Libraries.Security.Shared;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.PasswordGeneration
{
    public class PasswordGeneratorHelperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PasswordGeneratorHelperTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void CreatePasswordString()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>
            {
                {CharacterVariant.Digits, CharacterLists.Digits},
                {CharacterVariant.Lowercase, CharacterLists.Lowercase},
                {CharacterVariant.Uppercase, CharacterLists.Uppercase}
            };

            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);
            var characterCount = 12;

            // Act
            var result = passwordGeneratorHelper.CreatePasswordString(characterCount);

            // Assert
            _outputHelper.WriteLine(result);
        }

        [Fact]
        public void AddCharacterVariantsToDictionary()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>();
            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);
            var characterVariants = new[] { CharacterVariant.Lowercase, CharacterVariant.Special };

            // Act
            passwordGeneratorHelper.AddCharacterVariantsToDictionary(characterVariants);

            // Assert
            characters.Should().HaveCount(characterVariants.Length);
        }

        [Fact]
        public void EnsurePositiveCharacterVariantCount_PositiveCount_DoesNotThrow()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>
            {
                {CharacterVariant.Digits, CharacterLists.Digits},
                {CharacterVariant.Lowercase, CharacterLists.Lowercase},
                {CharacterVariant.Uppercase, CharacterLists.Uppercase}
            };
            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);
            var characterVariants = new[] { CharacterVariant.Lowercase, CharacterVariant.Special };

            // Act and Assert
            passwordGeneratorHelper.EnsurePositiveCharacterVariantCount(characterVariants);
        }

        [Fact]
        public void EnsurePositiveCharacterVariantCount_NonPositiveCount_ThrowsArgumentException()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>();
            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);
            var characterVariants = Array.Empty<CharacterVariant>();

            // Assert
            Assert.Throws<ArgumentException>(() => passwordGeneratorHelper.EnsurePositiveCharacterVariantCount(characterVariants));
        }

        [Fact]
        public void EnsurePositiveCharacterCount_PositiveCount_DoesNotThrow()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>();
            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);
            var characterCount = 12;

            // Act and Assert
            passwordGeneratorHelper.EnsurePositiveCharacterCount(characterCount);
        }

        [Fact]
        public void EnsurePositiveCharacterCount_NonPositiveCount_ThrowsArgumentException()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>
            {
                {CharacterVariant.Digits, CharacterLists.Digits},
                {CharacterVariant.Lowercase, CharacterLists.Lowercase},
                {CharacterVariant.Uppercase, CharacterLists.Uppercase}
            };
            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);
            var characterCount = 0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => passwordGeneratorHelper.EnsurePositiveCharacterCount(characterCount));
        }

        [Fact]
        public void GetRandomCharacterVariant()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>
            {
                {CharacterVariant.Digits, CharacterLists.Digits},
                {CharacterVariant.Lowercase, CharacterLists.Lowercase},
                {CharacterVariant.Uppercase, CharacterLists.Uppercase}
            };
            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);

            // Act
            var result = passwordGeneratorHelper.GetRandomCharacterVariant();

            // Assert
            characters.Should().ContainKey(result);
        }

        [Fact]
        public void GetRandom_RunTwice_ValuesShouldBeDifferent()
        {
            // Arrange
            var characters = new Dictionary<CharacterVariant, string>();
            var passwordGeneratorHelper = new PasswordGeneratorHelper(characters);
            var maxValue = 1000;

            // Act
            var result1 = passwordGeneratorHelper.GetRandom(maxValue);
            var result2 = passwordGeneratorHelper.GetRandom(maxValue);

            // Assert
            result1.Should().NotBe(result2);
            result1.Should().BeInRange(0, maxValue);
        }
    }
}