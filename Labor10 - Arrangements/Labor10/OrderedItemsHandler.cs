using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labor10
{
    public enum SortingMethod
    {
        Selection,
        Bubble, 
        Insertion
    }
    public class OrderedItemsHandler
    {
        public IComparable[] Tomb { get; private set; }

        public OrderedItemsHandler(IComparable[] tomb)
        {
            Tomb = tomb;
        }

        //2.5 Novekvo rendezettseg vizsgalat
        public bool IsOrdered(bool isAscending = true)
        {
            if(isAscending == true)
            {
                //true = noveko rendezettseg vizsgalata a-z
                for (int i = 0; i < Tomb.Length - 1; i++)
                {
                    if (Tomb[i].CompareTo(Tomb[i + 1]) > 0) return false;
                }
                return true;
            }
            else
            {
                //false = csokkeno rendezettseg vizsgalata z-a
                for (int i = 0; i < Tomb.Length - 1; i++)
                {
                    if (Tomb[i].CompareTo(Tomb[i + 1]) < 0) return false;
                }
                return true;
            }            
        }

        //megforditja a tombot -> Array.Reverse();
        private void Reverse()
        {
            IComparable[] temp = new IComparable[Tomb.Length];
            int index = -1;
            for (int i = Tomb.Length-1; i >= 0; i--)
            {
                temp[++index] = Tomb[i];
            }
            Tomb = temp;
            //GC.Collect();
        }

        //rendezes 
        public void Sort(SortingMethod sortingMethod, bool isAscending = true)
        {
            Func<IComparable, IComparable, bool> less;
            if (isAscending) less = (a, b) => a.CompareTo(b) < 0;
            else less = (a, b) => a.CompareTo(b) > 0;

            switch (sortingMethod)
            {
                case SortingMethod.Selection:
                    SelectionSort(less);
                    break;
                case SortingMethod.Bubble:
                    BubbleSort(less);
                    break;
                case SortingMethod.Insertion:
                    InsertionSort((a, b) => a.CompareTo(b) < 0);
                    break;
                default:
                    break;
            }

            //isAscending == false -> Reverse();
            if (!isAscending) Reverse();
        }

        //Beilleszteses rendezes
        private void InsertionSort(Func<IComparable, IComparable, bool> less)
        {
            if (less == null) throw new ArgumentNullException();

            for (int i = 0; i < Tomb.Length; i++)
            {
                int j = i - 1;
                IComparable temp = Tomb[i];

                while(j >= 0 && less(temp, Tomb[j]))
                {
                    Tomb[j + 1] = Tomb[j];
                    --j;
                }
                Tomb[j + 1] = temp;
            }
        }

        //Buborek rendezes
        public void BubbleSort(Func<IComparable, IComparable, bool> less)
        {
            if (less == null) throw new ArgumentNullException();

            int i = Tomb.Length - 1;
            while(i > 0)
            {
                int lastSwap = 0;
                for (int j = 0; j < i; j++)
                {
                    if (less(Tomb[j + 1], Tomb[j]))
                    {
                        /*IComparable temp = Tomb[j];
                        Tomb[j] = Tomb[j + 1];
                        Tomb[j + 1] = temp;
                        lastSwap = j;*/
                        (Tomb[j], Tomb[j + 1]) = (Tomb[j + 1], Tomb[j]); //csere egyszerubben
                    }
                }
                i = lastSwap;
            }
        }

        //Kivalasztasos rendezes
        public void SelectionSort(Func<IComparable, IComparable, bool> less)
        {
            if (less == null) throw new ArgumentNullException();

            for (int i = 0; i < Tomb.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = minIndex; j < Tomb.Length; j++)
                {
                    if (less(Tomb[j], Tomb[minIndex]))
                    {
                        minIndex = j;
                    }
                }
                IComparable temp = Tomb[minIndex];
                Tomb[minIndex] = Tomb[i];
                Tomb[i] = temp;
            }
        }

        //Binaris kereses
        public int BinKeresRek(IComparable keresett)
        {
            if (!IsOrdered()) throw new NotOrderedItemsException(this.Tomb);
            return BinkeresRek(0, Tomb.Length - 1, keresett);
        }

        public int BinkeresRek(int bal, int jobb, IComparable keresett)
        {
            if (bal > jobb) return -1;

            int center = (bal + jobb) / 2;
            //megtalaltuk a keresettet
            if (keresett == Tomb[center]) return center;
            //kisebb feleben van
            if (Tomb[center].CompareTo(keresett) > 0) return BinkeresRek(bal, center - 1, keresett);
            //nagyob feleban van
            return BinkeresRek(center + 1, jobb, keresett);
        }

        //Legkisebb nem nagyobb elem keresese
        public int NemNagyobbKeres(IComparable keresett)
        {   
            if (!IsOrdered()) throw new NotOrderedItemsException(Tomb);

            int bal = 0;
            int jobb = Tomb.Length - 1;
            int idx = Tomb.Length;

            while(bal<=jobb)
            {
                int center = (bal + jobb) / 2;
                if (Tomb[center].CompareTo(keresett) == -1 || Tomb[center].CompareTo(keresett) == 0)
                {
                    idx = center;
                    jobb = center - 1;
                }
                else bal = center + 1;
            }
            return idx;
        }

        //Keresett erteknel elso nagyobb elem
        public int ElsoNagyobbKeres(IComparable keresett)
        {
            int bal = 1;
            int jobb = Tomb.Length - 1;
            int idx = Tomb.Length;

            while(bal<=jobb)
            {
                int center = (jobb + bal) / 2;
                if (Tomb[center].CompareTo(keresett) == 1)
                {
                    idx = center;
                    jobb = center - 1;
                }
                else bal = center + 1;
            }
            return idx;
        }
    }
}
