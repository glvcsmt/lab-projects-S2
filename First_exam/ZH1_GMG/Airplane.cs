using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_GMG
{
    public abstract class Airplane : IAircraft, IComparable
    {
        protected string name;

        protected Airplane(string name, int weight)
        {
            this.name = name;
            Weight = weight;
            this.Passangers = 0;
        }

        public int Weight { get; }

        public int Passangers { get; protected set; }

        public int CompareTo(object? obj)
        {
            return this.Passangers.CompareTo((obj as Airplane).Passangers);
        }

        public abstract bool TakeOff();
    }
}
