using System.Security.Cryptography;
namespace Domain.Cipher
{
    public class EncryptionService : IEncryptionService
    {
        private readonly byte[] encryptionKey;

        public EncryptionService(byte[] encryptionKey)
        {
            this.encryptionKey = encryptionKey;
        }

        public string Encrypt(string plaintext)
        {
            byte[] cyphertextBytes;
            using var aes = Aes.Create();
            var encryptor = aes.CreateEncryptor(encryptionKey, aes.IV);
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (var streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plaintext);
                    }
                }
                cyphertextBytes = memoryStream.ToArray();

                return new AesCipherText(aes.IV, cyphertextBytes).ToString();
            }
        }

        public string Decrypt(string ciphertext)
        {
            var cbcCiphertext = AesCipherText.FromBase64String(ciphertext);
            using var aes = Aes.Create();
            var decryptor = aes.CreateDecryptor(encryptionKey, cbcCiphertext.Iv);
            using (var memoryStream = new MemoryStream(cbcCiphertext.CiphertextBytes))
            {
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (var streamReader = new StreamReader(cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}