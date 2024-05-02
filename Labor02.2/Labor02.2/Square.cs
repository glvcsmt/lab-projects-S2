using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._2
{
    internal class Square : Rectangle
    {

        public Square(int h, int w, string color = "red", bool isHoley = false) : base(h, w, color, isHoley)
        {

        }
        public int A
        {
            get { return this.height; }
            set
            {
                this.height = value;
                this.width = value;
            }
        }

        public override bool Equals(object? obj)
        {
            if(obj is Square)
            {
                Square temp = (Square)obj;
                return this.height == temp.height;
            }
            return false;
        }

        public override string? ToString()
        {
            return $"Negyzet - {base.ToString()}";

        }
    }
}
