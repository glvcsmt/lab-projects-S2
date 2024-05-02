using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    internal class MissingPassportException : Exception
    {
        public MissingPassportException() : base("Hianyzik az utlevel!")
        {
        }
    }
}
