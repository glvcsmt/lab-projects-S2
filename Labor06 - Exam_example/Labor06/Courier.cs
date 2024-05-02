using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor06
{
    public class Courier
    {
        IDeliverable[] tomb;
        int ossztomeg;

        public int Ossztomeg
        {
            get
            {
                int ossz = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] != null) ossz += tomb[i].Weight;

                    /*ossz += tomb[i]?.Weight ?? 0;*/
                }
                return ossz;
            }
        }

        public Courier(int tombHossz)
        {
            this.tomb = new IDeliverable[tombHossz];
        }

        public void PickUpItem(IDeliverable item)
        {
            int idx = -1; //legutolso betett csomag indexe
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != null) ++idx;
            }
            if (idx == tomb.Length - 1) throw new DeliveryException("A tombbe nem fer tobb elem!");
            this.tomb[++idx] = item;

            /* //eldeontes tetel - P tulajdonsag null?
            int j = 0;
            while((j<tomb.Length-1) && !(tomb[j] == null))
            {
                j++;
            }
            if (j == tomb.Length) throw new DeliveryException("A tomb tele van!");//tele van -> dobas
            this.tomb[++j] = item;*/
        }

        public IDeliverable[] FragilesSorted()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] is FragileParcel) db++;

            }

            IDeliverable[] result = new IDeliverable[db];
            int idx = 0; // a kovetkezot melyik indexere kell rakni
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] is FragileParcel) result[idx++] = tomb[i];

            }

            Array.Sort(result);
            return result;
        }
    }
}
