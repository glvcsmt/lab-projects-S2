using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._3
{
    internal abstract class BankAccount : BankingService
    {
        protected int currentBalance;
        public BankAccount(string owner) : base(owner)
        {
         
        }

        public int CurrentBalance { get => currentBalance; }

        public void Deposit(int amount)
        {
            currentBalance += amount;
        }
        public abstract bool Withdraw(int amount);
    }
}
