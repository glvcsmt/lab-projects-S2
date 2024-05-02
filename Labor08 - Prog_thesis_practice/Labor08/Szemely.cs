using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor08
{
    internal class Szemely
    {
        string nev;
        bool nem;
        int progjegy;

        public Szemely(string nev, bool nem, int progjegy)
        {
            this.nev = nev;
            this.nem = nem;
            this.progjegy = progjegy;
        }

        public string Nev { get => nev; }
        public bool Nem { get => nem; }
        public int Progjegy { get => progjegy; }
    }
}
