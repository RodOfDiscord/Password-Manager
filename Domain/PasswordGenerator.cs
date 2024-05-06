using System.Text;

namespace Domain
{
    public class PasswordGenerator
    {
        const string Symbols_a_z = "abcdefghijklmnopqrstuvwxyz";
        const string Symbols_A_Z = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Symbols_0_9 = "0123456789";
        const string SpecialSymbols = ":;<=>?!@#$%^&*(){}[]|./,'";
        StringBuilder symbols = new StringBuilder();

        public PasswordGenerator()
        {
            symbols.Append(Symbols_a_z);
        }

        public string Generate(int length)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                sb.Append(symbols[rnd.Next(symbols.Length)]);
            }
            return sb.ToString();
        }

        public PasswordGenerator IncludeLowercase()
        {
            if (!symbols.ToString().Contains(Symbols_a_z))
                symbols.Append(Symbols_a_z);
            return this;
        }

        public PasswordGenerator IncludeUppercase()
        {
            if (!symbols.ToString().Contains(Symbols_A_Z))
                symbols.Append(Symbols_A_Z);
            return this;
        }

        public PasswordGenerator IncludeDigits()
        {
            if (!symbols.ToString().Contains(Symbols_0_9))
                symbols.Append(Symbols_0_9);
            return this;
        }

        public PasswordGenerator IncludeSpecialSymbols()
        {
            if (!symbols.ToString().Contains(SpecialSymbols))
                symbols.Append(SpecialSymbols);
            return this;
        }
    }
}