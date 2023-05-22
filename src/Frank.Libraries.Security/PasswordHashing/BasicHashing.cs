using System.Security.Cryptography;

namespace Frank.Libraries.Security.PasswordHashing;

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