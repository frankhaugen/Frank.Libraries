using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Frank.Libraries.AI.LanguageDetection
{
    public class Languages : IEnumerable<Language>
    {
        private readonly IList<Language> _list;
        private const string ResourceNamePrefix = "Frank.Libraries.AI.LanguageDetection.";

        public Languages()
        {
            var assembly = GetType().Assembly;
            using var stream = assembly.GetManifestResourceStream(ResourceNamePrefix + "languages.json")!;
            using var streamReader = new StreamReader(stream);
            var json = streamReader.ReadToEnd();
            _list = JsonSerializer.Deserialize<List<Language>>(json);
        }

        /// <inheritdoc />
        public IEnumerator<Language> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
