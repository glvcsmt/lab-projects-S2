using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor06
{
    public class IncorrectOrientationException : DeliveryException
    {
        public FragileParcel Csomag {  get; set; }
        public IncorrectOrientationException(string? message, FragileParcel fp) : base(message)
        {
            this.Csomag = fp;
        }
    }
}
