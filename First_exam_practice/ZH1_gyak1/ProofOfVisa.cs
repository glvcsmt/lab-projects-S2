using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public abstract class ProofOfVisa : IDocument, IComparable
    {
        public string Name { get; }

        public int PassportNumber { get; }

        public string Purpose { get; protected set; }

        public DateTime EnterBy { get; protected set; }

        protected ProofOfVisa(string name, int passportNumber, string purpose, DateTime enterBy)
        {
            Name = name;
            PassportNumber = passportNumber;
            Purpose = purpose;
            if (EnterBy < DateTime.Today) throw new EntryDatePassed();
            else EnterBy = enterBy;
        }

        protected ProofOfVisa(string name, int passportNumber, DateTime enterBy)
        {
            Name = name;
            PassportNumber = passportNumber;
            if (EnterBy < DateTime.Today) throw new EntryDatePassed();
            else EnterBy = enterBy;
        }

        public int CompareTo(object? obj)
        {
            return EnterBy.CompareTo((obj as ProofOfVisa).EnterBy);
        }

        public abstract bool isNotExpired(DateTime date);

        public override string? ToString()
        {
            return $"Name: {this.Name}\nPassport Number: {this.PassportNumber}\nPorpuse: {this.Purpose}" +
                $"\nEnterBy: {this.EnterBy}";
        }
    }
}
