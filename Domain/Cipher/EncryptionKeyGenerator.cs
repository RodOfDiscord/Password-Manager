using System.Security.Cryptography;

namespace Domain.Cipher
{
    public static class EncryptionKeyGenerator
    {
        public static byte[] Generate()
        {
            var randomBytes = new byte[32];
            using (var rngCsp = RandomNumberGenerator.Create())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
