using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor06
{
    public class NormalParcel : Parcel
    {
        public NormalParcel(int weight, string address) : base(weight, address)
        {
            Random rnd = new Random();
            this.ElhelyezesiMod = (Mod)rnd.Next(0, 3);
        }

        public override double CalculatePrice(bool fromLocker)
        {
            double price = 500 + this.Weight;
            if (fromLocker == true) price -= 250;
            return price;
        }
    }
}
