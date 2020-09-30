using Frank.Libraries.Security.PasswordHashing;
using System;
using System.Security.Cryptography;

namespace Frank.Libraries.Security
{
    /// <summary>
    /// A class containing the logic to hash and comparing a password
    /// </summary>
    public class PasswordHasher
    {
        private readonly PasswordHashingConfiguration _configuration;

        /// <summary>
        /// Instantiate with custom configuration
        /// </summary>
        /// <param name="configuration"></param>
        public PasswordHasher(PasswordHashingConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Instantiate with default configuration
        /// </summary>
        public PasswordHasher()
        {
            _configuration = new PasswordHashingConfiguration();
        }

        /// <summary>
        /// Converts a cleartext password to a salted hash
        /// </summary>
        /// <param name="password">A password</param>
        /// <returns>A hashed and salted password</returns>
        public string HashPassword(string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            byte[] salt;
            byte[] bytes;
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, _configuration.SaltSize, _configuration.Pbkdf2IterationCount, _configuration.HashAlgorithmName))
            {
                salt = rfc2898DeriveBytes.Salt;
                bytes = rfc2898DeriveBytes.GetBytes(_configuration.Pbkdf2SubkeyLength);
            }

            var inArray = new byte[1 + _configuration.SaltSize + _configuration.Pbkdf2SubkeyLength];
            inArray[0] = _configuration.Version;
            Buffer.BlockCopy(salt, 0, inArray, 1, _configuration.SaltSize);
            Buffer.BlockCopy(bytes, 0, inArray, 1 + _configuration.SaltSize, _configuration.Pbkdf2SubkeyLength);

            return Convert.ToBase64String(inArray);
        }

        /// <summary>
        /// Compares and verifies that the cleartext password and the hashed and salted password is the same
        /// </summary>
        /// <param name="password">Cleartext password</param>
        /// <param name="hashedPassword">Hash of password</param>
        /// <returns>True if the password and the hashed password matches</returns>
        public bool CheckPasswordAgainstHash(string password, string hashedPassword)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            if (hashedPassword == null)
            {
                return false;
            }

            var numArray = Convert.FromBase64String(hashedPassword);
            if (numArray.Length < 1)
            {
                return false;
            }

            var version = numArray[0];
            if (version > _configuration.Version)
            {
                return false;
            }

            var salt = new byte[_configuration.SaltSize];
            Buffer.BlockCopy(numArray, 1, salt, 0, _configuration.SaltSize);

            var a = new byte[_configuration.Pbkdf2SubkeyLength];
            Buffer.BlockCopy(numArray, 1 + _configuration.SaltSize, a, 0, _configuration.Pbkdf2SubkeyLength);

            byte[] bytes;
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, _configuration.Pbkdf2IterationCount, _configuration.HashAlgorithmName))
            {
                bytes = rfc2898DeriveBytes.GetBytes(_configuration.Pbkdf2SubkeyLength);
            }

            return CryptographicOperations.FixedTimeEquals(a, bytes);
        }
    }
}
