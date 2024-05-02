using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor03._2
{
    internal abstract class Flat : IRealEstate
    {
        protected double area;
        protected int roomsCount;
        protected int inhabitantsCount;
        protected int unitPrice;

        public int InhabitantsCount { get => inhabitantsCount; }

        public int TotalValue()
        {
            return (int)(this.area * this.unitPrice);
        }

        protected Flat(double area, int roomsCount, int unitPrice)
        {
            this.area = area;
            this.roomsCount = roomsCount;
            this.inhabitantsCount = 0;
            this.unitPrice = unitPrice;
        }

        public abstract bool MoveIn(int newInhabitants);

        public override string? ToString()
        {
            return $"Terulet: {area} m^2," +
                $" szobaszam: {roomsCount}, " +
                $"lakok szama: {inhabitantsCount}, " +
                $"negyzetmeterar: {unitPrice}";
        }
    }
}
