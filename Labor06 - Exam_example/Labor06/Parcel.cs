using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor06
{
    public enum Mod
    {
        Arbitrary, 
        Horizontal, 
        Vertical
    }
    public abstract class Parcel : IDeliverable, IComparable
    {
        public int Weight { get; set ; }
        public string Address { get ; set ; }

        public Mod ElhelyezesiMod { get; set; }

        protected Parcel(int weight, string address, Mod elhelyezesiMod)
        {
            Weight = weight;
            Address = address;
            ElhelyezesiMod = elhelyezesiMod;
        }

        protected Parcel(int weight, string address)
        {
            Weight = weight;
            Address = address;
            this.ElhelyezesiMod = Mod.Arbitrary;
        }

        public abstract double CalculatePrice(bool fromLocker);

        public int CompareTo(object? obj)
        {
            Parcel temp = (Parcel)obj;

            if (temp.Weight < this.Weight) return 1;
            if (temp.Weight > this.Weight) return -1;
            return 0;
        }

        public override string? ToString()
        {
            return $"Címzett: {this.Address} / Elhelyezesi mod: {this.ElhelyezesiMod} / Tömeg: {this.Weight} g";
        }   
    }
}