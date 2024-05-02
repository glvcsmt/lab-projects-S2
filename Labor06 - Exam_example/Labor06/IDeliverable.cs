using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor06
{
    public interface IDeliverable
    {
        public int Weight { get;  set; }
        public string Address { get;  set; }
        double CalculatePrice(bool fromLocker);
    }
}
