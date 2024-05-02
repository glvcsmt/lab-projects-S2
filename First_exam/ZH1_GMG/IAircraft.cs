using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_GMG
{
    public interface IAircraft
    {
        public int Weight { get; }
        public int Passangers { get; }

        bool TakeOff();
    }
}
