using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._3
{
    internal class SavingsAccount : BankAccount
    {
        int interest;
        int defInterest = 27;
        public SavingsAccount(string owner) : base(owner)
        {

        }

        public int Interest { get => interest; set => interest = value; }

        public override bool Withdraw(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
