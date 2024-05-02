namespace TrainingCosts
{
    internal class Program
    {   //metódus annak eldöntésére, hogy páros-e a szám
        static bool ParosE(int a)
        {
            if(a % 2 == 0) return true;
            return false;
        }

        //metódus, ami összegzés tételével összeadja a tömb elemeit 
        static int Osszegtetel(int[] t, Predicate<int> pre)
        {
            int sum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (pre(t[i])) sum += t[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 2, 3, 4, 5, 6 };

            //Predicate pl
            Predicate<int> method = ParosE;

            int sum = Osszegtetel(tomb, method);
            Console.WriteLine(sum);

            int sum2 = Osszegtetel(tomb, x => x % 2 == 0);
            Console.WriteLine(sum2);

            int sum3 = Osszegtetel(tomb, y => y % 2 != 0 && y > 4);
            Console.WriteLine(sum3);
        }
    }
}