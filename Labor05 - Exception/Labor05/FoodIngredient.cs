using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Egyseg
{
    liter, 
    kilogramm,
    darab,
    csomag
}

namespace Labor05
{
    public class FoodIngredient
    {
        string nev;
        int mennyiseg;
        Egyseg egyseg;

        public FoodIngredient(string nev, int mennyiseg, Egyseg egyseg)
        {
            this.nev = nev;
            this.mennyiseg = mennyiseg;
            this.egyseg = egyseg;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        internal Egyseg Egyseg { get => egyseg; set => egyseg = value; }

        public override string? ToString()
        {
            return $"{this.nev} - {this.mennyiseg} - {this.egyseg}";
        }
    }
}
