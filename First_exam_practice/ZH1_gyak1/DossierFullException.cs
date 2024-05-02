using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    internal class DossierFullException : Exception
    {
        BorderControl bc;

        public DossierFullException(BorderControl bc)
        {
            this.bc = bc;
        }
    }
}
