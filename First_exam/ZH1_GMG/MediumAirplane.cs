using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_GMG
{
    public class MediumAirplane : SmallAirplane
    {
        int cargoWeight;

        public MediumAirplane(string name, int weight, PlaneType planeType, int cargoWeight) : base(name, weight, planeType)
        {
            this.cargoWeight = cargoWeight;
            Random rnd = new Random();
            this.Passangers = rnd.Next(80, 201);
        }

        public override bool TakeOff()
        {
            if (((80 * this.Passangers) + this.Weight + this.cargoWeight) < 45000) return true;
            return false;
        }

        public override string? ToString()
        {
            if(TakeOff() == true) return base.ToString() + " felszállhat";
            return base.ToString() + " Nem szállhat fel";
        }
    }
}
