namespace Labor03._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lodgings l = new Lodgings(100, 3, 1000000);
            Console.WriteLine(l);
            Console.WriteLine(l.GetCost(12));
            Console.WriteLine(l.IsBooked);
            Console.WriteLine(l.TotalValue());
            Console.WriteLine(l.Book(12));
            Console.WriteLine(l.GetCost(12));
            Console.WriteLine(l.IsBooked);
            Console.WriteLine(l.MoveIn(3));
            Console.WriteLine(l.GetCost(12));
            Console.WriteLine(l.MoveIn(100));

        }
    }
}