using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ZH1_GMG
{
    public class Aerodrome
    {
        IAircraft[] aircrafts;

        public Aerodrome(int aircraftsLength)
        {
            this.aircrafts = new IAircraft[aircraftsLength];
        }

        public int passangerSum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < aircrafts.Length; i++)
                {
                    if (aircrafts[i] != null) sum += aircrafts[i].Passangers;
                }
                return sum;
            }
        }

        public void AddPlane(IAircraft plane)
        {
            int idx = 0;
            while (idx < aircrafts.Length && aircrafts[idx] != null) idx++;
            if (idx == aircrafts.Length) throw new NoMorePortException(plane);
            aircrafts[++idx] = plane;
        }

        public IAircraft[] Prioritize()
        {
            IAircraft[] temp = new IAircraft[this.aircrafts.Length];
            int idx = -1;
            for (int i = 0; i < aircrafts.Length; i++)
            {
                if (aircrafts[i] is SmallAirplane || aircrafts[i] is MediumAirplane)
                {
                    temp[++idx] = aircrafts[i];
                }
            }

            IAircraft[] selectedAndSorted = new IAircraft[idx+1];
            for (int j = 0; j < selectedAndSorted.Length; j++)
            {
                selectedAndSorted[j] = temp[j];
            }

            Array.Sort(selectedAndSorted);

            return selectedAndSorted;
        }

    }
}
