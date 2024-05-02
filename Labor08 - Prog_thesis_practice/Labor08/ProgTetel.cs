using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor08
{
    internal class ProgTetel
    {

        public static int[] TombDuplazo(int[] x)
        {
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * 2;
            }
            return y;
        }

        public static int[] ParostKivalogat(int[] x)
        {
            int[] y = new int[x.Length];
            int db = -1;

            for (int i = 0; i < y.Length; i++)
            {
                y[i] = -1;
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db = db + 1;
                    y[db] = x[i];
                }
            }
            db++;
            return y;
        }

        public static int[] ParostKivalogat(int[] x, ref int db)
        {
            int[] y = new int[x.Length];
            db = -1;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db = db + 1;
                    y[db] = x[i];
                }
            }
            db++;
            return y;
        }

        public static int ParostHelybenKivalogat(ref int[] x)
        {
            int db = -1;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db++;
                    x[db] = x[i];
                }
            }
            return db + 1;
        }

        public static void SzamokatSzetValogat(int[] tomb, ref int[] paros, ref int[] paratlan, ref int db1, ref int db2)
        {
            db1 = -1;
            db2 = -1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    db1 = db1 + 1;
                    paros[db1] = tomb[i];
                }
                else
                {
                    db2 = db2 + 1;
                    paratlan[db2] = tomb[i];
                }
            }
            db1++;
            db2++;
        }

        public static void SzetvalogatHelyben(int[] x, ref int db)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int seged = x[0];

            while(bal < jobb)
            {
                while((bal < jobb) && !(x[jobb] % 2 == 0))
                {
                    jobb = jobb - 1;
                }
                if(bal < jobb)
                {
                    x[bal] = x[jobb];
                    bal = bal + 1;
                    while((bal < jobb) && (x[bal] % 2 == 0))
                    {
                        bal = bal + 1;  
                    }
                    if(bal < jobb)
                    {
                        x[jobb] = x[bal];
                        jobb = jobb - 1;
                    }
                }
            }
            x[bal] = seged;
            if (x[bal] % 2 == 0)
            {
                db = bal + 1;
            }else
            {
                db = bal;
            }
        }

    }
}
