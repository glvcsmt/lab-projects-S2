namespace Labor1
{
    class Program
    {
        static Cage[] cages = new Cage[4];

        static Cage Max(Race r)
        {
            int maxI = 0;

            for (int i = 1; i < cages.Length; i++)
            {
                if (cages[i].NumOfRace(r) > cages[maxI].NumOfRace(r))
                {
                    maxI = i;
                }
            }
            return cages[maxI];
        }
        static void Main(string[] args)
        {            
            
            cages[0] = new Cage(3);
            cages[1] = new Cage(4);
            cages[2] = new Cage(5);
            cages[3] = new Cage(8);

            Animal a1 = new Animal("Buksi", true, 55, Race.Kutya);
            Animal a2 = new Animal("Po", false, 200, Race.Panda);
            Animal a3 = new Animal("Fules", true, 6, Race.Nyul);
            Animal a4 = new Animal("Buksi klonja", true, 55, Race.Kutya);

            cages[0].Felvetel(a1);
            cages[0].Felvetel(a2);
            cages[0].Felvetel(a4);

            Animal[] dogs = cages[0].NamedRace(Race.Kutya);
            Cage big = Max(Race.Kutya);

            cages[3].Load("ketrec1.txt");

        }
    }
}