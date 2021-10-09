using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Frank.Libraries.ML.LanguageDetection
{
    public class LanguageModels
    {
        public readonly IReadOnlyList<LanguageModel> List;

        public LanguageModels()
        {
            var assembly = GetType().Assembly;
            using var stream = assembly.GetManifestResourceStream($"{GetType().Namespace}.languages.json")!;
            using var streamReader = new StreamReader(stream);
            var rawString = streamReader.ReadToEnd();
            var json = Regex.Unescape(rawString);
            List = JsonConvert.DeserializeObject<List<LanguageModel>>(json);
        }
    }
}
