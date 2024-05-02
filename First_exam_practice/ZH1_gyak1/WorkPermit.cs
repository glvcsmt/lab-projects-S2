using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public class WorkPermit : EntryPermit
    {
        public WorkPermit(string name, int passportNumber, DateTime enterBy, string fieldOfWork ) : base(name, passportNumber, enterBy)
        {
            this.DurationOfStay = 120;
            this.Purpose = "Work";
            this.FieldOfWork = fieldOfWork;
        }

        public string FieldOfWork { get; }

        public override bool isValid()
        {
            string fields = "Accounting, Agriculture, Architecture, " +
                "Aviation, Construction, Dentistry, Drafting, Engineering, " +
                "Fine arts, Fishing, Food service, General labor, Healthcare, " +
                "Manufacturing, Research, Sports, Statistics, Surveying";
            if (fields.Contains(this.FieldOfWork) == true && base.isValid() == true) return true;
            return false;
        }

        public override string? ToString()
        {
            return base.ToString() + $"\nField of work: {this.FieldOfWork}";
        }
    }
}
