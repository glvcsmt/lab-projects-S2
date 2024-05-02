namespace Labor08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] tomb = new int[] { 1, 2, 3 };
            int[] eredmeny = ProgTetel.TombDuplazo(tomb);
            int[] paros = ProgTetel.ParostKivalogat(tomb);

            int parosokSzama = 0;
            int[] paros2 = ProgTetel.ParostKivalogat(tomb, ref parosokSzama);

            int pSz = ProgTetel.ParostHelybenKivalogat(ref tomb);*/

            /*
            tomb = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                Random rnd = new Random();
                tomb[i] = rnd.Next(100);
            }
            pSz = ProgTetel.ParostHelybenKivalogat(ref tomb);
            */

            /*int[] tomb2 = new int[] {1, 2, 3, 4, 5, 6};
            int[] paros3 = new int[tomb.Length];
            int[] paratlan = new int[tomb.Length];
            int dbParos = 0;
            int dbParatlan = 0;

            ProgTetel.SzamokatSzetValogat(tomb2, ref paros3, ref paratlan, ref dbParos, ref dbParatlan);*/

            int[] tomb3 = new int[] {1, 2, 3, 4, 5, 7};
            int dbP = 0;
            ProgTetel.SzetvalogatHelyben(tomb3, ref dbP);
            ;
        }
    }
}
