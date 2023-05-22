using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Frank.Libraries.Security.PasswordHashing;

public class PasswordHashingConfiguration
{
    public readonly byte Version = 1;
    [Range(1024, 65536)] public int Pbkdf2IterationCount { get; set; } = 64000;
    [Range(64, 65536)] public int Pbkdf2SubkeyLength { get; set; } = 512 / 8;
    [Range(64, 65536)] public int SaltSize { get; set; } = 256 / 8;
    public HashAlgorithmName HashAlgorithmName { get; set; } = HashAlgorithmName.SHA512;
}

public enum HashingClassAlgorithms
{
    MD5 = 0,
    SHA1 = 1,
    SHA256 = 2,
    SHA384 = 3,
    SHA512 = 4
}

/// <summary>
///     This is a helper that allows to hash input in a low-security manner. This is not intended for actual security
///     purposes
/// </summary>
/// <remarks>NOT SECURE</remarks>
public sealed class BasicHashing
{
    public BasicHashing(HashingClassAlgorithms hashingAlgorithm) => HashingAlgorithms = hashingAlgorithm;

    public HashingClassAlgorithms HashingAlgorithms { get; }

    public HashAlgorithm CreateNewInstance()
    {
        HashAlgorithm result = null;

        switch (HashingAlgorithms)
        {
            case HashingClassAlgorithms.MD5:
                result = MD5.Create();
                break;
            case HashingClassAlgorithms.SHA1:
                result = SHA1.Create();
                break;
            case HashingClassAlgorithms.SHA256:
                result = SHA256.Create();
                break;
            case HashingClassAlgorithms.SHA384:
                result = SHA384.Create();
                break;
            case HashingClassAlgorithms.SHA512:
                result = SHA512.Create();
                break;
        }

        return result;
    }
}

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

            result = string.Concat(Array.ConvertAll(hash, h => h.ToString($"{(upperCase ? "X2" : "x2")}")));
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