namespace Domain.Cipher
{
    public class AesCipherText
    {
        public byte[] Iv { get; }
        public byte[] CiphertextBytes { get; }

        public static AesCipherText FromBase64String(string data)
        {
            var dataBytes = Convert.FromBase64String(data);
            return new AesCipherText(
                dataBytes.Take(16).ToArray(),
                dataBytes.Skip(16).ToArray()
            );
        }

        public AesCipherText(byte[] iv, byte[] ciphertextBytes)
        {
            Iv = iv;
            CiphertextBytes = ciphertextBytes;
        }

        public override string ToString()
        {
            return Convert.ToBase64String(Iv.Concat(CiphertextBytes).ToArray());
        }
    }
}
