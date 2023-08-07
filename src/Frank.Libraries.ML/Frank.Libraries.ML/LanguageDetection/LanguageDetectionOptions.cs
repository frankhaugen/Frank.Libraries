// ReSharper disable FunctionComplexityOverflow
// ReSharper disable TooManyDependencies

namespace Frank.Libraries.ML.LanguageDetection;

/// <summary>
///     Options for language detection
/// </summary>
public class LanguageDetectionOptions
{
    /// <summary>
    /// </summary>
    /// <param name="maxTextLength"></param>
    /// <param name="nGramLength"></param>
    /// <param name="trials"></param>
    /// <param name="randomSeed"></param>
    /// <param name="alpha"></param>
    /// <param name="baseFrequency"></param>
    /// <param name="convergenceThreshold"></param>
    /// <param name="probabilityThreshold"></param>
    /// <param name="maxIterations"></param>
    /// <param name="alphaWidth"></param>
    public LanguageDetectionOptions(
        int? maxTextLength = 10000,
        int? nGramLength = 3,
        int? trials = 7,
        int? randomSeed = 1,
        double? alpha = 0.5,
        int? baseFrequency = 10000,
        double? convergenceThreshold = 0.99999,
        double? probabilityThreshold = 0.5,
        int? maxIterations = 1000,
        double? alphaWidth = 0.05)
    {
        MaxTextLength = maxTextLength;
        NGramLength = nGramLength;
        Trials = trials;
        RandomSeed = randomSeed;
        Alpha = alpha;
        BaseFrequency = baseFrequency;
        ConvergenceThreshold = convergenceThreshold;
        ProbabilityThreshold = probabilityThreshold;
        MaxIterations = maxIterations;
        AlphaWidth = alphaWidth;
    }

    public int? MaxTextLength { get; set; }

    public int? NGramLength { get; set; }

    public int? Trials { get; set; }

    public int? RandomSeed { get; set; }

    public double? Alpha { get; set; }

    public int? BaseFrequency { get; set; }

    public double? ConvergenceThreshold { get; set; }

    public double? ProbabilityThreshold { get; set; }

    public int? MaxIterations { get; set; }

    public double? AlphaWidth { get; set; }
}