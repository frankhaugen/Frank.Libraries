﻿using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Frank.Libraries.Security.Encryption
{
    public class StringEncryptionService
    {
        private const int Keysize = 128;

        private const int DerivationIterations = 1000;

        public static string Encrypt(string passPhrase, string plainText)
        {
            var saltStringBytes = GenerateRandomEntropy();
            var ivStringBytes = GenerateRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations);
            var keyBytes = password.GetBytes(Keysize / 8);
            using var symmetricKey = new RijndaelManaged();
            symmetricKey.BlockSize = Keysize;
            symmetricKey.Mode = CipherMode.CBC;
            symmetricKey.Padding = PaddingMode.PKCS7;
            using var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes);
            using var memoryStream = new MemoryStream();
            using var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            var cipherTextBytes = saltStringBytes;
            cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
            cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string passPhrase, string cipherText)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();
            using var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations);
            var keyBytes = password.GetBytes(Keysize / 8);
            using var symmetricKey = new RijndaelManaged();
            symmetricKey.BlockSize = Keysize;
            symmetricKey.Mode = CipherMode.CBC;
            symmetricKey.Padding = PaddingMode.PKCS7;
            using var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes);
            using var memoryStream = new MemoryStream(cipherTextBytes);
            using var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            var plainTextBytes = new byte[cipherTextBytes.Length];
            var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }

        private static byte[] GenerateRandomEntropy()
        {
            var randomBytes = new byte[Keysize / 8];
            using var rngCsp = new RNGCryptoServiceProvider();
            rngCsp.GetBytes(randomBytes);
            return randomBytes;
        }
    }
}