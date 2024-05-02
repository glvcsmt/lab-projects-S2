using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class ArrayStatistics
    {
        int[] tomb;

        public ArrayStatistics(int[] tomb)
        {
            this.tomb = tomb;
        }

        //Sorozatszamitas tetel - 22.old
        public int Total()
        {
            int ertek = 0;
            for (int i = 0; i <= tomb.Length-1; i++)
            {
                ertek += tomb[i];
            }
            return ertek;
        }

        //Eldontes tetel - 24.old
        public bool Contains(int number)
        {
            int i = 0;
            while(i <= tomb.Length-1 && !(number == tomb[i]))
            {
                i++;
            }
            bool van = i <= tomb.Length - 1;
            return van;
        } 

        //Novekvo rendezettseg vizsgalata tetel - 27.old
        public bool Sorted()
        {
            int i = 0;
            while(i <= tomb.Length-2 && (tomb[i] <= tomb[i + 1]))
            {
                i++;
            }
            bool rendezett = i > tomb.Length - 2;
            return rendezett;
        }

        //Linearis kereses tetel - 29.old
        public int FirstGreater(int value)
        {
            int i = 0;
            while(i <= tomb.Length-1 && !(tomb[i] > value))
            {
                i++;
            }
            bool van = i <= tomb.Length - 1;
            if (van == true)
            {
                int idx = i;
                return idx;
            }
            else return -1;
        }
        //megszamlalas, max. kivalasztas

        //Buborek rendezes tetel - 98.old
        public void Sort()
        {
            for (int i = tomb.Length - 1; i < 1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (tomb[j] > tomb[i])
                    {
                        int temp = tomb[i];
                        tomb[i] = tomb[j+1];
                        tomb[j+1] = temp;
                    }
                }
            }
        }
    }
}
