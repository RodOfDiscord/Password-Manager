using System.Security.Cryptography;

namespace Presentation
{
    public class KeyManager
    {
        private readonly string filepath;

        public KeyManager(string filepath)
        {
            this.filepath = filepath;
        }

        public void EncryptToFile(byte[] key)
        {
            byte[] encryptedKey = ProtectedData.Protect(key, null, DataProtectionScope.CurrentUser);

            File.WriteAllBytes(filepath, encryptedKey);
        }

        public byte[] GetDecryptedKey()
        {
            byte[] encryptedKey = File.ReadAllBytes(filepath);
            byte[] originalText = ProtectedData.Unprotect(encryptedKey, null, DataProtectionScope.CurrentUser);

            return originalText;
        }

        public bool KeyExists()
        {
            return File.Exists(filepath);
        }
    }
}