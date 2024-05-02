using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
    enum Race
    {
        Kutya,
        Panda,
        Nyul
    }
    internal class Animal
    {
        string name;
        bool gender;
        int weight;
        Race race;

        public Animal(string name, bool gender, int weight, Race race)
        {
            this.name = name;
            this.gender = gender;
            this.weight = weight;
            this.race = race;
        }

        public string Name { get => name; }
        public bool Gender { get => gender; }
        public int Weight { get => weight; }
        internal Race Race { get => race; }
    }
}
