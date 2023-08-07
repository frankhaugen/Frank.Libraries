namespace Frank.Libraries.ML.LanguageDetection;

public static class Languages
{
    private static object _lockObj = new object();
    private static IReadOnlyList<LanguageModel>? _list;

    private static JsonSerializerOptions _jsonSerializerOptions = new()
    {
        Converters =
        {
            new JsonStringEnumConverter()
        },
        PropertyNameCaseInsensitive = true,
        WriteIndented = true
    };

    public static IReadOnlyList<LanguageModel> List
    {
        get
        {
            LazyInitializer.EnsureInitialized(ref _list, ref _lockObj, InitializeList);
            return _list;
        }
    }

    private static IReadOnlyList<LanguageModel> InitializeList()
    {
        var assembly = typeof(Languages).Assembly;

        using var stream = assembly.GetManifestResourceStream(GetResourceName());
        if (stream == null)
            throw new InvalidDataException("Resource stream not found.");

        using var streamReader = new StreamReader(stream);
        string rawString;
        try
        {
            rawString = streamReader.ReadToEnd();
        }
        catch (IOException e)
        {
            throw new InvalidDataException("Failed to read the resource stream.", e);
        }

        var json = Regex.Unescape(rawString);
        return ParseJson(json);
    }

    private static IReadOnlyList<LanguageModel> ParseJson(string json)
    {
        List<LanguageModel>? list;
        try
        {
            list = JsonSerializer.Deserialize<List<LanguageModel>>(json, _jsonSerializerOptions);
        }
        catch (JsonException e)
        {
            throw new InvalidDataException("Failed to deserialize json.", e);
        }

        if (list == null)
            throw new InvalidDataException("Json is null.");

        return list.OrderBy(x => x.LanguageCode)
                   .ToList();
    }

    private static string GetResourceName() => $"{typeof(Languages).Namespace}.languages.json";
}