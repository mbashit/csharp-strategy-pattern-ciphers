using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Encryptor
    {
        private IEncryptionStrategy strategy;
        
        public Encryptor(IEncryptionStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void setStrategy(IEncryptionStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string encode(string input)
        {
            return strategy.encode(input);
        }
    }
}
