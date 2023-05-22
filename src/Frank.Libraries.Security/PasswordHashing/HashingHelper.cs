using System.Security.Cryptography;
using System.Text;

namespace Frank.Libraries.Security.PasswordHashing;

public class HashingHelper
{
    private static void Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new
                ArgumentNullException
                ("Input parameter is empty or only contains whitespace");
        }
    }

    private static void Validate(HashAlgorithm algorithm)
    {
        if (algorithm == null)
        {
            throw new ArgumentNullException("algorithm is null");
        }
    }

    private static HashAlgorithm CreateNewInstance(HashingClassAlgorithms algorithm) => new BasicHashing(algorithm).CreateNewInstance();

    private static void ValidateParams(string input, HashAlgorithm algorithm)
    {
        Validate(input);

        Validate(algorithm);
    }

    private static string ComputeHash(string input, HashAlgorithm algorithm, bool upperCase = true)
    {
        var result = string.Empty;

        var hashingService = algorithm;

        using (hashingService)
        {
            var hash = hashingService.ComputeHash(Encoding.UTF8.GetBytes(input));

            result = string.Concat(Array.ConvertAll(hash, h => h.ToString($"{(upperCase
                ? "X2"
                : "x2")}")));
        }

        return result;
    }

    private static HashAlgorithm ProcessAlgorithm(string input, HashingClassAlgorithms algorithm)
    {
        var result = CreateNewInstance(algorithm);

        ValidateParams(input, result);

        return result;
    }

    public static string ComputeHashInUpperCase(string input, HashingClassAlgorithms algorithm)
    {
        var result = ProcessAlgorithm(input, algorithm);

        return ComputeHash(input, result);
    }

    /// <summary>
    ///     Computes the hash returns its value.
    /// </summary>
    /// <param name="input">plainText</param>
    /// <param name="algorithm">Name of the algorithm that you are interested using.</param>
    /// <returns></returns>
    public static string ComputeHashInLowerCase(string input, HashingClassAlgorithms algorithm)
    {
        var result = ProcessAlgorithm(input, algorithm);

        return ComputeHash(input, result, false);
    }
}