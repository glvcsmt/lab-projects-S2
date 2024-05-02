using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor06
{
    public class Envelope : IDeliverable
    {
        //mezok
        string leiras;
        public int Weight { get; set; }
        public string Address { get; set; }

        public Envelope(string leiras, int weight, string address)
        {
            this.leiras = leiras;
            Weight = weight;
            Address = address;
        }

        public double CalculatePrice(bool fromLocker)
        {
            if (this.Weight <= 50) return 200;
            if (this.Weight <= 500) return 400;
            if (this.Weight <= 2000) return 1000;

            throw new OverweightException();
        }

        public override string? ToString()
        {
            return $"Címzett: {this.Address} / Leírás: {this.leiras} / Tömeg: {this.Weight} g";
        }
    }
}
