using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.RegularExpressions;
using Frank.Libraries.Security.Shared;

namespace Frank.Libraries.Security.RandomPhraseGeneration
{
    public class Dictionaries
    {
        public readonly IReadOnlyList<string> Nouns;
        public readonly IReadOnlyList<string> Adjectives;
        public readonly IReadOnlyList<string> Verbs;

        private const string ResourceNamePrefix = "Frank.Libraries.Security.RandomPhraseGeneration.Resources.";

        public Dictionaries()
        {
            Nouns = GetResource("english-nouns.txt")
                .Split('\n');
            Adjectives = GetResource("english-adjectives.txt")
                .Split('\n');
            Verbs = GetResource("english-verbs.txt")
                .Split('\n');
        }

        private string GetResource(string filename)
        {
            var assembly = GetType()
                .Assembly;
            using var stream = assembly.GetManifestResourceStream(ResourceNamePrefix + filename)!;
            using var streamReader = new StreamReader(stream!);
            var rawString = streamReader.ReadToEnd();
            return Regex.Unescape(rawString);
        }

        public IReadOnlyDictionary<WordVariant, IReadOnlyList<string>> GetDictionaryOfDictionaries() =>
            new ReadOnlyDictionary<WordVariant, IReadOnlyList<string>>(new Dictionary<WordVariant, IReadOnlyList<string>>
            {
                { WordVariant.Adjective, Adjectives },
                { WordVariant.Noun, Nouns },
                { WordVariant.Verb, Verbs }
            });
    }
}