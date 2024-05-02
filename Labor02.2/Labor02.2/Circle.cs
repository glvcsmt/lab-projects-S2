using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._2
{
    internal class Circle : Shape
    {
        int r;

        public override bool Equals(object? obj)
        {
            if (obj is Circle)
            {
                Circle temp = (Circle)obj;
                return this.r == temp.r;
            }
            return false;
        }

        public Circle(int r, string color = "red", bool isHoley = false) : base(color, isHoley)
        {
            this.r = r;
        }

        public int R { get => r; set => r = value; }

        public override double Area()
        {
            return r * r * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * r * Math.PI;
        }
        public override string? ToString()
        {
            return $"Kor - {base.ToString()}";

        }
    }
}
