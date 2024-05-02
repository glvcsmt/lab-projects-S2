using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor08
{
    internal class Kurzus
    {
        Szemely[] szemelyek;

        public Kurzus(int letszam)
        {
            if (letszam > 24) throw new MaxLetszamException();
            this.szemelyek = new Szemely[letszam];
        }

        public bool Felvetel(Szemely sz)
        {
            int index = 0;
            while (index < this.szemelyek.Length && szemelyek[index] != null) index++;
            if (index == this.szemelyek.Length) return false;
            else
            {
                szemelyek[++index] = sz;
                return true;
            }
        }


    }
}
