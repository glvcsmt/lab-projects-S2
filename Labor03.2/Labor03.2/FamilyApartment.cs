using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor03._2
{
    internal class FamilyApartment : Flat
    {
        int childrenCount;

        public FamilyApartment(double area, int roomsCount, int unitPrice) : base(area, roomsCount, unitPrice)
        {
            this.childrenCount = 0;
            this.inhabitantsCount = 0;
        }

        public bool ChildIsBorn()
        {
            if (this.inhabitantsCount - childrenCount < 2) return false;

            this.inhabitantsCount++;
            this.childrenCount++;
            return true;
        }

        public override bool MoveIn(int newInhabitants)
        {
            double total = ((inhabitantsCount - childrenCount) + (0.5 * childrenCount) + newInhabitants);

            if(total > this.roomsCount * 2) return false;

            if (this.area < (((inhabitantsCount - childrenCount) + newInhabitants) * 10) + childrenCount * 5) return false;

            this.inhabitantsCount += newInhabitants;
            return true;
        }

        public override string? ToString()
        {
            return base.ToString()+$", gyerekek szama: {this.childrenCount}";
        }
    }
}
