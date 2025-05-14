using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    interface IEncryptionStrategy
    {
        public string encode(string source);
    }

    class CaesarCipher : IEncryptionStrategy
    {
        private int shift;

        public CaesarCipher(int shift)
        {
            this.shift = shift;
        }

        public string encode(string source)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in source)
            {
                char characterToAdd = c;
                if (Char.IsLetter(c))
                {
                    char baseChar = Char.IsLower(c) ? 'a' : 'A';
                    characterToAdd = (char)((c - baseChar + shift) % 26 + baseChar);
                }
                sb.Append(characterToAdd);
            }
            return sb.ToString();
        }
    }

    class XorCipher : IEncryptionStrategy
    {
        private char key;

        public XorCipher(char key)
        {
            this.key = key;
        }

        public string encode(string source)
        {
            char[] chars = source.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] ^ key);
            }

            return new string(chars);
        }
    }

    class ReverseCipher : IEncryptionStrategy
    {
        public string encode(string source)
        {
            return new string(source.Reverse().ToArray());
        }
    }
}
