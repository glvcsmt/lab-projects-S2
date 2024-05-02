using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._2
{
    internal abstract class Shape
    {
        bool isHoley;
        string color;

        public string Color { get => color; set => color = value; }

        protected Shape(string color, bool isHoley = false)
        {
            this.isHoley = isHoley;
            this.color = color;
        }

        public void MakeHoley()
        {
            this.isHoley = true;
        }

        public abstract double Perimeter();
        public abstract double Area();

        public override string? ToString()
        {
            return $"{this.color} - {(this.isHoley ? "" : "nem")}lyukas - K: {this.Perimeter()} - T: {this.Area()}"; //ternary operator
        }
    }
}
