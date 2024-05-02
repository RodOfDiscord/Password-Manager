using System.Security.Cryptography;

namespace Domain.Cipher
{
    public static class EncryptionKeyGenerator
    {
        public static byte[] Generate()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = RandomNumberGenerator.Create())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
