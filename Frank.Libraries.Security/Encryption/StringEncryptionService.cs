using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Frank.Libraries.Security.Encryption
{
    public class StringEncryptionService
    {
        public string EncryptString(string key, string plainInput)
        {
            var iv = new byte[16];
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;
            var cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
            using var memoryStream = new MemoryStream();
            using var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
            using var streamWriter = new StreamWriter(cryptoStream);
            streamWriter.Write(plainInput);
            var array = memoryStream.ToArray();
            return Convert.ToBase64String(array);
        }

        public string DecryptString(string key, string cipherText)
        {
            var iv = new byte[16];
            var buffer = Convert.FromBase64String(cipherText);
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;
            var cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
            using var memoryStream = new MemoryStream(buffer);
            using var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read);
            using var streamReader = new StreamReader(cryptoStream);
            return streamReader.ReadToEnd();
        }
    }
}