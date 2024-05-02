using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
    internal class Cage
    {

        Animal[] animals;
        int numOfAnimals = 0;

        public Cage(int sizeOfCage)
        {
            //max 10 allat mehet bele
            if (sizeOfCage > 10) sizeOfCage = 0;                
            animals = new Animal[sizeOfCage];         
        }

        public bool Felvetel(Animal a)
        {
            //early exit
            //ha mar tele van, akkor --> return false
            if(numOfAnimals >= animals.Length) return false;

            //hozzadajuk numOfAnimals indexre
            animals[numOfAnimals] = a;
            numOfAnimals++;
            //jelezzuk a hozzaadas sikeresseget
            return true;
        }

        public bool Torol(string name)
        {
            //vegigarjuk a belso tombot
            //i. -> null -> false
            //i = nev -> torles
            //i -> null
                //utolsot -> i.
                //utolso -> null
            for (int i = 0; i < animals.Length; i++)
            {
                //nincs benne, nem tudjuk kitorolni
                if (animals[i] == null) return false;

                if (animals[i].Name == name)
                {
                    //megtalaltuk, ki kell torolni
                    animals[i] = animals[numOfAnimals - 1];
                    animals[numOfAnimals - 1] = null;
                    numOfAnimals--;
                    return true; 
                }
            }
            return false;
        }

        public int NumOfRace(Race r)
        {
            int count = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null) return count;
                if (animals[i].Race == r) count++;
            }
            return count;
        }

        public bool IsThere(Race r, bool g)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null) return false;
                if (animals[i].Race == r && animals[i].Gender == g) return true;
            }
            return false;
        }
        
        public Animal[] NamedRace(Race r)
        {
            int count = NumOfRace(r);
            Animal[] temp = new Animal[count];
            int index = 0;

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null) return temp;

                if (animals[i].Race == r)
                {
                    temp[index] = animals[i];
                    index++;
                }
            }
            return temp;
        } 

        public double Average(Race r)
        {
            int count = NumOfRace(r);
            int sum = 0;

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null)
                {
                    //return count = (0 ? 0.0 : (sum / count));
                }

                if (animals[i].Race == r)
                {
                    sum += animals[i].Weight;
                }
            }
            return sum/count;
        }

        public bool Mate()
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null) return false;

                for (int j = 0; j < i; j++)
                {
                    if (animals[i].Race == animals[j].Race && animals[i].Gender != animals[j].Gender) return true;
                }
            }
            return false;
        }

        public override string? ToString()
        {
            string temp = "";
            for (int i = 0; i < numOfAnimals; i++)
            {
                temp += $"{animals[i].Name} - {animals[i].Race}\n";
            }
            return temp;
        }

        public void Load(string file)
        {
            string[] data = File.ReadAllLines(file);

            foreach (string line in data)
            {
                string[] count = line.Split(";");
                
                Race r = (Race)Enum.Parse(typeof(Race), count[3]);
                Animal temp = new(count[0], bool.Parse(count[1]), int.Parse(count[2]), r);

                Felvetel(temp);
            }
        }
    }
}
