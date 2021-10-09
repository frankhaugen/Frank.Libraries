using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Frank.Libraries.Enums.Extensions;
using Frank.Libraries.Extensions;
using Frank.Libraries.ML.LanguageDetection;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.LanguageDetection
{
    public class LanguagesTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public LanguagesTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void ListLanguages()
        {
            // Arrange
            var languages = new LanguageModels();

            // Act
            var result = languages.List;

            // Assert
            result.Should().NotBeNull();

            foreach (var language in result)
            {
                _outputHelper.WriteLine($"{language.LanguageCode},{language.LanguageCode.GetName()}");
            }
        }

        [Fact]
        public void GetLanguages_HasLanguages_RandomLanguageExistWithValues()
        {
            // Arrange
            var languages = new LanguageModels();

            // Act
            var result = languages.List.Random();

            // Assert
            result.Should().NotBeNull();
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
            result?.Frequency.Should().NotBeNull();
            result?.WordCount.Should().NotBeNull();
        }
    }
}
