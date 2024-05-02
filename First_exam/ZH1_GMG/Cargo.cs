using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_GMG
{
    public class Cargo : IAircraft
    {
        int cargoSumWeight;

        public int Weight { get; }

        public int Passangers { get; }

        public Cargo(int cargoSumWeight, int weight)
        {
            this.cargoSumWeight = cargoSumWeight;
            this.Weight = weight;
            this.Passangers = 1;
        }

        public bool TakeOff()
        {
            if (((80 * this.Passangers) + this.Weight + this.cargoSumWeight) < 120000) return true;
            return false;
        }
    }
}
