using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using Frank.Libraries.Security.RandomPhraseGeneration;
using Frank.Libraries.Security.Shared;

namespace Frank.Libraries.Security;

public class RandomPhraseGenerator
{
    private readonly Dictionaries _dictionaries;

    public RandomPhraseGenerator() => _dictionaries = new Dictionaries();

    public string GetRandomPhrase(int length = 5, bool capitalizeRandomWords = false)
    {
        var wordList = new List<string>();
        for (var i = 0; i < length; i++)
        {
            var variant = new EnumerableRandomizer<WordVariant>(Enum.GetValues<WordVariant>()).GetRandomValue();
            var word = new EnumerableRandomizer<string>(_dictionaries.GetDictionaryOfDictionaries()[variant]).GetRandomValue();

            if (capitalizeRandomWords && RandomNumberGenerator.GetInt32(0, 1) == 1)
            {
                word = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(word);
            }

            wordList.Add(word);
        }

        return string.Join(' ', wordList);
    }

    public string GetAdjectiveNounPair() => string.Join(' ', GetStructuredRandomWordList(WordVariant.Adjective, WordVariant.Noun));

    public List<string> GetStructuredRandomWordList(params WordVariant[] variants) => variants.Select(wordVariant => new EnumerableRandomizer<string>(_dictionaries.GetDictionaryOfDictionaries()[wordVariant]).GetRandomValue())
                                                                                              .ToList();

    public List<string> GetRandomWordList(params WordVariant[] variants) => new EnumerableRandomizer<WordVariant>(variants).Shuffle()
                                                                                                                           .Select(wordVariant => new EnumerableRandomizer<string>(_dictionaries.GetDictionaryOfDictionaries()[wordVariant]).GetRandomValue())
                                                                                                                           .ToList();
}