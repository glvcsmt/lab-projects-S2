using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._3
{
    internal class CreditAccount : BankAccount
    {
        int credit;
        public CreditAccount(string owner, int credit) : base(owner)
        {
            this.credit = credit;
        }

        public int Credit { get => credit; }

        public override bool Withdraw(int amount)
        {
            if ((this.currentBalance+credit) - amount > 0) return false;
            this.currentBalance -= amount;
            return true;
        }
    }
}
