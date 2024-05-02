using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._2
{
    internal class Rectangle : Shape
    {
        protected int height, width;

        public override bool Equals(object? obj)
        {
            if(obj is Rectangle)
            {
                Rectangle temp = (Rectangle)obj;
                return this.height == temp.height && this.width == temp.width;
            }
            return false;
        }

        public Rectangle(int h, int w, string color = "red", bool isHoley = false) : base(color, isHoley)
        {
            this.height = h;
            this.width = w;
        }

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public override string? ToString()
        {
            return $"Teglalap - {base.ToString()}";
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2*(height + width);
        }

    }
}
