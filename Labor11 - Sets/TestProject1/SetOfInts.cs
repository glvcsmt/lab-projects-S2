using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class SetOfInts
    {
        //adattagok
        int[] tomb;

        public SetOfInts(int[] tomb)
        {
            if (!(RendezettE(tomb))) throw new ArgumentException("Nem rendezett!");
            if (!(EgyediE(tomb))) throw new ArgumentException("Nem egyedi!");

            this.tomb = tomb;
        }

        private bool RendezettE(int[] t)
        {
            for (int i = 0; i < t.Length-1; i++)
            {
                if (t[1].CompareTo(t[i + 1]) > 0) return false;
            }
            return true;
        }

        private bool EgyediE(int[] t)
        {
            for (int i = 0; i < t.Length - 1; i++)
            {
                if (t[i].Equals(t[i + 1])) return false;
            }
            return true;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is SetOfInts)) throw new ArgumentException();

            SetOfInts temp = (SetOfInts)obj;

            //EE
            for (int i = 0; i < this.tomb.Length; i++)
            {
                if ((this.tomb[i] != temp.tomb[i])) return false;
            }
            //hossz nem egyezik
            if(this.tomb.Length != temp.tomb.Length) return false;
            return true;
        }

        //index
        //-1 -> nincs benne
        //ha benne van akkor az indexet adja vissza
        public int BinKeres(int keresett)
        {
            int bal = 0;
            int jobb = tomb.Length - 1;
            int center = (bal + jobb) / 2;

            while((bal <= jobb) && (tomb[center] != keresett))
            {
                if (tomb[center] > keresett) jobb = center - 1;
                else bal = center + 1;
                center = (bal + jobb) / 2;
            }
            if (bal <= jobb) return center;
            else return -1;
        }

        //reszhalmaza-e other a tombnek
        public bool Subset(SetOfInts other)
        {
            if(this.tomb.Length < other.tomb.Length) return false;

            int i = 0, j = 0;

            int m = this.tomb.Length - 1;
            int n = other.tomb.Length - 1;

            while ((i <= m) && (j <= n) && (this.tomb[i] >= other.tomb[j]))
            {
                if (this.tomb[i] == (other.tomb[j])) i++;
                j++;
            }
            return (i>this.tomb.Length);
        }

        public SetOfInts Intersection(SetOfInts other)
        {
            //int[] temp -> min
            int[] temp = new int[Math.Min(this.tomb.Length, other.tomb.Length)];
            int i = 0, j = 0, db = -1;

            int m = this.tomb.Length - 1, n = other.tomb.Length - 1;

            //algoritmus
            while((i <= m) && (j <= n))
            {
                if (this.tomb[i] < other.tomb[j]) i++;
                else if (this.tomb[i] > other.tomb[j]) j++;
                else
                {
                    db++;
                    temp[db] = this.tomb[i];
                    i++;
                    j++;
                }
            }

            //Array.Resize(ref temp, db)
            Array.Resize(ref temp, db);

            //vagy
            //int[] temp 2 -> db meretu
            //atmasolom az ertekeket
            /*int[] temp2 = new int[db];
            for (int i = 0; i < temp2.Length; i++)
            {
                temp2[i] = temp[i];
            }*/

            //return SetOfInts(temp)
            return new SetOfInts(temp);
        }
    }
}
