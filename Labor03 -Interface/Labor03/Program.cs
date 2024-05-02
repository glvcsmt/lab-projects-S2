namespace Labor03
{
    interface IInterface
    {
        //eloirasok
        //prop, metodus --> public

        int Kor { get; set; }

        void Kiir();
    }

    class Dog : IInterface, IComparable
    {
        int kor;
        public int Kor { get => kor; set => this.kor = value; }

        public int CompareTo(object? obj)
        {
            if (!(obj is Dog)) return 0;

            Dog temp = (Dog)obj;

            if(this.kor < temp.kor) return -1;
            
            if(this.kor > temp.kor) return 1;

            return 0; //megegyeznek
        }

        public void Kiir()
        {
            Console.WriteLine("Kutya.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog[] kutyak = new Dog[]
            {
                new Dog(){Kor = 10},
                new Dog(){Kor = 5}
            };

            Array.Sort(kutyak);
            ;
        }
    }
}