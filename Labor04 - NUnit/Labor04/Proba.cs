using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor04
{
    public class Proba
    {
        int ertek;

        public Proba(int ertek)
        {
            this.ertek = ertek;
        }

        public override string? ToString()
        {
            return $"Ertek: {this.ertek}";
        }
    }
}
