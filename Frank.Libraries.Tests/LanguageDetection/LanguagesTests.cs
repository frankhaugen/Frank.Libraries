using System.Linq;
using FluentAssertions;
using Frank.Libraries.AI.LanguageDetection;
using Frank.Libraries.Enums.Extensions;
using Frank.Libraries.Extensions;
using Xunit;

namespace Frank.Libraries.Tests.LanguageDetection
{
    public class LanguagesTests
    {
        [Fact]
        public void GetLanguages_HasLanguages_RandomLanguageExistWithValues()
        {
            // Arrange
            var languages = new LanguageModels();

            // Act
            var result = languages.List.Random();

            // Assert
            result.Should().NotBeNull();
            result.LanguageCode.Should().NotBeNull();
            result.Frequency.Should().NotBeNull();
            result.WordCount.Should().NotBeNull();
        }

        [Fact]
        public void GetNorwegian_HasLanguages_NorwegianExists()
        {
            // Arrange
            var languages = new LanguageModels();

            // Act
            var result = languages.List.FirstOrDefault(x => x.LanguageCode.GetName() == "Norwegian");

            // Assert
            result.Should().NotBeNull();
            result.LanguageCode.Should().NotBeNull();
            result.Frequency.Should().NotBeNull();
            result.WordCount.Should().NotBeNull();
        }
    }
}
