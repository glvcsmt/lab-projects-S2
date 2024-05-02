using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor06
{
    public class FragileParcel : Parcel
    {
        public FragileParcel(int weight, string address, Mod elhelyezesiMod) : base(weight, address, elhelyezesiMod)
        {
            if(elhelyezesiMod == Mod.Arbitrary) 
                throw new IncorrectOrientationException("Torekeny csomag eseten az elhelyezes modja nem lehet tetszoleges!", this);
        }

        public override double CalculatePrice(bool fromLocker)
        {
            if (fromLocker == true) throw new DeliveryException("Torekeny csomag nem adhato fel automatabol!");
            return 1000 + 2 * this.Weight;           
        }
    }
}
