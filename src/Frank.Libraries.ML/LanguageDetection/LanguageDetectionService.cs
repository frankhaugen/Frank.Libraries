using System.Collections.Generic;
using System.Linq;
using Frank.Libraries.Enums.Countries;

namespace Frank.Libraries.ML.LanguageDetection;

public class LanguageDetectionService
{
    private readonly DetectionEngine _detectionEngine;
    private readonly LanguageDetectionOptions _options;
    private readonly WordProbabilities _wordLanguageProbabilities;

    public LanguageDetectionService(LanguageDetectionOptions options)
    {
        _options = options;
        _wordLanguageProbabilities = new WordProbabilities();
        _detectionEngine = new DetectionEngine(options, _wordLanguageProbabilities);
        _wordLanguageProbabilities.AddLanguages(_options.NGramLength.GetValueOrDefault(3));
    }

    /// <summary>
    ///     Checks to see if the provided language is the one provided
    /// </summary>
    /// <param name="languageCode">The three letter ISO language code</param>
    /// <param name="text">The <paramref name="text" /> to be analyzed</param>
    /// <returns>True, false or null</returns>
    public bool Is(LanguageCode languageCode, string text)
    {
        var detectedLanguage = _detectionEngine.DetectAll(text)
                                               .FirstOrDefault();
        return detectedLanguage != null && detectedLanguage.LanguageCode == languageCode;
    }

    /// <summary>
    ///     Detects and selects the most likely language. Can return null if probability is too low
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public Language? Detect(string text) => _detectionEngine.DetectAll(text)
                                                            .FirstOrDefault();

    /// <summary>
    ///     Gets the list of languages detected from the text inputted
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public IEnumerable<Language> DetectAll(string text) => _detectionEngine.DetectAll(text);
}