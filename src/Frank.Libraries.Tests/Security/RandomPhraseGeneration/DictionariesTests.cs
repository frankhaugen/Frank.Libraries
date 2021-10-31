using Frank.Libraries.Security.RandomPhraseGeneration;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Security.RandomPhraseGeneration
{
    public class DictionariesTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public DictionariesTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void GetAdjectives_ReturnsAdjectives()
        {
            // Arrange
            var dictionaries = new Dictionaries();

            // Act
            var result = dictionaries.Adjectives;

            // Assert
            _outputHelper.WriteLine(string.Join('\n', result));
        }

        [Fact]
        public void GetNouns_ReturnsNouns()
        {
            // Arrange
            var dictionaries = new Dictionaries();

            // Act
            var result = dictionaries.Nouns;

            // Assert
            _outputHelper.WriteLine(string.Join('\n', result));
        }
    }
}