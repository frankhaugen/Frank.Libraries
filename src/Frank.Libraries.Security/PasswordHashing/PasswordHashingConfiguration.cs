using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Frank.Libraries.Security.PasswordHashing;

public class PasswordHashingConfiguration
{
    public readonly byte Version = 1;
    [Range(1024, 65536)] public int Pbkdf2IterationCount { get; set; } = 64000;
    [Range(64, 65536)] public int Pbkdf2SubkeyLength { get; set; } = 512 / 8;
    [Range(64, 65536)] public int SaltSize { get; set; } = 256 / 8;
    public HashAlgorithmName HashAlgorithmName { get; set; } = HashAlgorithmName.SHA512;
}