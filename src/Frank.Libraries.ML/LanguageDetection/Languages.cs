using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Frank.Libraries.ML.LanguageDetection;

public static class Languages
{
    public static readonly IReadOnlyList<LanguageModel> List;

    static Languages()
    {
        var assembly = typeof(Languages).Assembly;
        using var stream = assembly.GetManifestResourceStream($"{typeof(Languages).Namespace}.languages.json")!;
        using var streamReader = new StreamReader(stream);
        var rawString = streamReader.ReadToEnd();
        var json = Regex.Unescape(rawString);
        var list = JsonConvert.DeserializeObject<List<LanguageModel>>(json) ?? new List<LanguageModel>();
        List = list.OrderBy(x => x.LanguageCode)
                   .ToList();
    }
}