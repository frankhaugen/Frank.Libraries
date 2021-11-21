using System.Linq;
using FluentAssertions;
using Frank.Libraries.Enums.Extensions;
using Frank.Libraries.Extensions;
using Frank.Libraries.ML.LanguageDetection;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.ML.LanguageDetection
{
    public class LanguagesTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public LanguagesTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void ListLanguages()
        {
            // Arrange
            var languages = Languages.List;

            // Act
            var result = languages;

            // Assert
            result.Should()
                  .NotBeNull();

            foreach (var language in result)
            {
                _outputHelper.WriteLine($"{language.LanguageCode},{language.LanguageCode.GetName()}");
            }
        }

        [Fact]
        public void GetLanguages_HasLanguages_RandomLanguageExistWithValues()
        {
            // Arrange
            var languages = Languages.List;

            // Act
            var result = languages.Random();

            // Assert
            result.Should()
                  .NotBeNull();
            result.Frequency.Should()
                  .NotBeNull();
            result.WordCount.Should()
                  .NotBeNull();
        }

        [Fact]
        public void GetNorwegian_HasLanguages_NorwegianExists()
        {
            // Arrange
            var languages = Languages.List;

            // Act
            var result = languages.FirstOrDefault(x => x.LanguageCode.GetName() == "Norwegian");

            // Assert
            result.Should()
                  .NotBeNull();
            result?.Frequency.Should()
                  .NotBeNull();
            result?.WordCount.Should()
                  .NotBeNull();
        }

        [Fact]
        public void TestNGram_LessThanOne_ReturnsNull()
        {
            // Arrange
            var ngram = new NGram();

            // Act
            var result = ngram.Get(0);

            // Assert
            result.Should()
                  .BeNull();
        }

        [Fact]
        public void TestNGram_MoreThanMaxLength_ReturnsNull()
        {
            // Arrange
            var ngram = new NGram();

            // Act
            var result = ngram.Get(100);

            // Assert
            result.Should()
                  .BeNull();
        }

        [Fact]
        public void TestNGram_AddsAnAChar_ShouldNotReturnNull()
        {
            // Arrange
            var ngram = new NGram();

            // Act
            ngram.Add(char.Parse("a"));
            var result = ngram.Get(1);

            // Assert
            result.Should()
                  .NotBeNull();
        }

        [Fact]
        public void TestNGram_AddsSpaceChar_ShouldNotReturnNull()
        {
            // Arrange
            var ngram = new NGram();

            // Act
            ngram.Add(char.Parse(" "));
            ngram.Add(char.Parse("F"));
            var result = ngram.Get(1);

            // Assert
            result.Should()
                  .NotBeNull();
        }
    }
}