using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._3
{
    internal abstract class BankingService
    {
        Owner owner;
        public BankingService(string owner)
        {
            this.owner = new Owner(owner);
        }

        internal Owner Owner { get => owner; }
    }
}
