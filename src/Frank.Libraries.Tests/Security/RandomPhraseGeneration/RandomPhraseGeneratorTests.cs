using System.Diagnostics;
using FluentAssertions;
using Frank.Libraries.Security;
using Frank.Libraries.Security.Shared;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Security.RandomPhraseGeneration
{
    public class RandomPhraseGeneratorTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public RandomPhraseGeneratorTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void GetRandomPhrase_NoCapitalization_NotEmptyOrWhitespace()
        {
            // Arrange
            var randomPhraseGenerator = new RandomPhraseGenerator();
            var length = 5;
            var capitalizeRandomWords = false;

            // Act
            var result = randomPhraseGenerator.GetRandomPhrase(length, capitalizeRandomWords);

            // Assert
            result.Should()
                  .NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void GetRandomPhrase_WithCapitalization_CapitalizedNotEmptyOrWhitespace()
        {
            // Arrange
            var randomPhraseGenerator = new RandomPhraseGenerator();
            var length = 5;
            var capitalizeRandomWords = true;

            // Act
            var result = randomPhraseGenerator.GetRandomPhrase(length, capitalizeRandomWords);

            // Assert
            result.Should()
                  .NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void GetAdjectiveNounPair_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var randomPhraseGenerator = new RandomPhraseGenerator();
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (var i = 0; i < 10; i++)
            {
                // Act
                var result = randomPhraseGenerator.GetAdjectiveNounPair();

                // Assert
                _outputHelper.WriteLine(result);
            }

            stopwatch.Stop();
            _outputHelper.WriteLine(stopwatch.Elapsed.TotalSeconds.ToString("R"));
        }

        [Fact]
        public void GetStructuredRandomWordList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var randomPhraseGenerator = new RandomPhraseGenerator();

            // Act
            var result = randomPhraseGenerator.GetStructuredRandomWordList(WordVariant.Adjective, WordVariant.Noun, WordVariant.Verb);

            // Assert
            _outputHelper.WriteLine(string.Join('\n', result));
        }

        [Fact]
        public void GetRandomWordList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var randomPhraseGenerator = new RandomPhraseGenerator();

            // Act
            var result = randomPhraseGenerator.GetRandomWordList(WordVariant.Adjective, WordVariant.Noun, WordVariant.Verb, WordVariant.Adjective, WordVariant.Noun);

            // Assert
            _outputHelper.WriteLine(string.Join('\n', result));
        }
    }
}