using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public class EntryPermit : ProofOfVisa
    {
        int durationOfStay;

        public EntryPermit(string name, int passportNumber, DateTime enterBy) : base(name, passportNumber, enterBy)
        {
        }

        public EntryPermit(string name, int passportNumber, string purpose, DateTime enterBy, int durationOfStay) : base(name, passportNumber, purpose, enterBy)
        {
            this.durationOfStay = durationOfStay;
        }

        public int DurationOfStay { get => durationOfStay; protected set => durationOfStay = value; }

        public override bool isNotExpired(DateTime date)
        {
            if (date < this.EnterBy) return true;
            return false;
        }

        public virtual bool isValid()
        {
            if(this.durationOfStay > 0) return true;
            return false;
        }

        public override string? ToString()
        {
            return "ENTRY PERMIT\n" + base.ToString() +$"\nDuration of stay: {durationOfStay}";
        }
    }
}
