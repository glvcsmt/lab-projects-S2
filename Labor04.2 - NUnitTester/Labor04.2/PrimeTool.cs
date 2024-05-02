using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor04._2
{
    public class PrimeTool
    {
        int szam;

        public PrimeTool(int szam)
        {
            this.szam = szam;
        }

        public bool IsPrime()
        {
            int i = 2;
            while((i <= Math.Sqrt(this.szam)) && (!(szam % i == 0)))
            {
                i++;
            }
            bool prim =  i > Math.Sqrt(this.szam);
            return prim;
        }
    }
}
