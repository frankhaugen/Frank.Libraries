using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Frank.Libraries.ML.LanguageDetection
{
    public class LanguageModels
    {
        public readonly IReadOnlyList<LanguageModel> List;
        private const string ResourceNamePrefix = "Frank.Libraries.AI.LanguageDetection.";

        public LanguageModels()
        {
            var assembly = GetType().Assembly;
            using var stream = assembly.GetManifestResourceStream(ResourceNamePrefix + "languages.json")!;
            using var streamReader = new StreamReader(stream);
            var rawString = streamReader.ReadToEnd();
            var json = Regex.Unescape(rawString);

            List = JsonConvert.DeserializeObject<List<LanguageModel>>(json);
        }
    }
}
