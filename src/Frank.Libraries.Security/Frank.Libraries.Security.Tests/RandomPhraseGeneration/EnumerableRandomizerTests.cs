using FluentAssertions;
using Frank.Libraries.Security.RandomPhraseGeneration;

namespace Frank.Libraries.Security.Tests.RandomPhraseGeneration;

public class EnumerableRandomizerTests
{
    [Fact]
    public void GetRandomValue_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var dictionaries = new Dictionaries();

        var enumerableRandomizer = new EnumerableRandomizer<string>(dictionaries.Adjectives);

        // Act
        var result1 = enumerableRandomizer.GetRandomValue();
        var result2 = enumerableRandomizer.GetRandomValue();

        // Assert
        result2.Should()
               .NotBe(result1);
    }
}