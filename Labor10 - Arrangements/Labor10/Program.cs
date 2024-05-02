namespace Labor10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBookItem[] phoneBookItems = new PhoneBookItem[]
            {
                new PhoneBookItem(){Nev = "Pisti", Telefonszam = 11},
                new PhoneBookItem(){Nev = "Jani", Telefonszam = 12},
                new PhoneBookItem(){Nev = "Bazsi", Telefonszam = 13}
            };

            Console.WriteLine(phoneBookItems[0].CompareTo(phoneBookItems[1]));
        }
    }
}
