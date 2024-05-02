using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor03._2
{
    internal class Garage : IRealEstate, IRent
    {
        double area;
        int unitPrice;
        bool isHeated;
        int months;
        bool isOccupied;

        public bool IsBooked
        {
            get
            {
                if(this.months > 0 || this.isOccupied == true) return true;
                return false;
            }
        }

        public bool Book(int months)
        {
            if (this.IsBooked == true) return false;

            this.months = months;
            return true;
        }

        public int GetCost(int months)
        {
            if (isHeated == true) return (int)((months * (TotalValue() / 120)) * 1.5);
            return (int)(months * (TotalValue() / 120));
        }

        public int TotalValue()
        {
            return (int)(this.area * this.unitPrice);
        }

        public void UpdateOccupied(bool yesOrNo)
        {
            this.isOccupied = yesOrNo;
        }

        public override string? ToString()
        {
            return $"Terulet: {this.area} m^2," +
                $"negyzetmeterar: {this.unitPrice}, " +
                $"futott-e: {this.isHeated}, " +
                $"foglalt honapok: {this.months}," +
                $"foglalt-e: {this.isOccupied}";
        }
    }
}