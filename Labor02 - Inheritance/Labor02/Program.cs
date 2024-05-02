namespace Labor02
{
    class Os
    {
        public Os(int ertek)
        {

        }

        public virtual void Kiir()
        {
            Console.WriteLine("Os");
        }
        protected int ertek = 100;
    }

    class Gyermek : Os
    {
        public Gyermek(int e) : base(e)
        {

        }

        public Gyermek() : this(200)
        {

        }
        public override void Kiir() 
        {
            Console.WriteLine(this.ertek);
        }
        public override string? ToString()
        {
            return "Gyermek objektum";
        }
        public override bool Equals(object? obj)
        {
            //Early exit
            if (obj is not Gyermek) return false;

            Gyermek temp = (Gyermek)obj;
            return this.ertek == temp.ertek;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gyermek gy1 = new Gyermek(10);

            Gyermek gy2 = new Gyermek(10);

            if(gy1.Equals(gy2)) Console.WriteLine("Ugyanaz");
        }
    }
}