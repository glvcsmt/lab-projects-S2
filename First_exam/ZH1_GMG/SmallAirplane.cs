using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_GMG
{
    public enum PlaneType
    {
        Cessna, 
        Piper, 
        Caravan,
        Boeing,
        Airbus,
        Embraer
    } 
    public class SmallAirplane : Airplane
    {
        PlaneType planeType;

        public SmallAirplane(string name, int weight) : base(name, weight)
        {
        }

        public SmallAirplane(string name, int weight, PlaneType planeType) : base(name, weight)
        {
            this.planeType = planeType;
        }

        public SmallAirplane(string name, int weight, PlaneType planeType, int passangers) : base(name, weight)
        {
            this.planeType = planeType;
            this.Passangers = passangers;
            if ((planeType == PlaneType.Cessna || planeType == PlaneType.Piper) && passangers > 4) throw new NotEnoughSeatsException();
            if(planeType == PlaneType.Caravan && passangers > 12) throw new NotEnoughSeatsException();
        }

        public override bool TakeOff()
        {
            if (((80 * this.Passangers) + this.Weight) < 12000) return true;
            return false;
        }

        public override string? ToString()
        {
            return $"{this.name} - [{(80 * this.Passangers + this.Weight)} / {this.Passangers} fő]";
        }
    }
}
