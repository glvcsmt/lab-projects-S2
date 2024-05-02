using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Labor03._2
{
    internal class Lodgings : Flat, IRent
    {
        int bookedMonths;

        public Lodgings(double area, int roomsCount, int unitPrice) : base(area, roomsCount, unitPrice)
        {
            this.bookedMonths = 0;
            this.inhabitantsCount = 0;
        }

        public bool IsBooked 
        {
            get 
            {
                if (this.bookedMonths == 0) return false;
                return true;
            }
        }

        public bool Book(int months)
        {
            if(!this.IsBooked)
            {
                this.bookedMonths = months;
                return true;
            }

            //foglalva van --> nem sikerult foglalni
            return false;
        }

        public int GetCost(int months)
        {
            if (this.inhabitantsCount == 0) return 0;

            return (int)(months * (((double)TotalValue() / 240) / this.inhabitantsCount));
        }

        public override bool MoveIn(int newInhabitants)
        {
            //Early exit
            //Nincs lefoglalva --> nem lehet koltozni
            if (this.IsBooked == false) return false;

            //eddigiek + uj lakok
            int total = this.inhabitantsCount = newInhabitants;

            //tobben vannak, mint 8 egy szobaban
            if (total > this.roomsCount * 8) return false;
            
            //nincs mindenkinek 2 m^2 --> nem lehet koltozni
            if (this.area < total * 2) return false;

            //lakoszam noveles - az ujakkal
            this.inhabitantsCount += newInhabitants;
            return true;
        }

        public override string? ToString()
        {
            return base.ToString()+$", foglalt honapok: {this.bookedMonths}";
        }
    }
}
