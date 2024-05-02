using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public class EntryDatePassed : Exception
    {
        string name;
        int passportNumber;
        DateTime EnterBy;

        public EntryDatePassed()
        {
        }

        public EntryDatePassed(string name, int passportNumber, DateTime enterBy)
        {
            this.name = name;
            this.passportNumber = passportNumber;
            EnterBy = enterBy;
        }
    }
}
