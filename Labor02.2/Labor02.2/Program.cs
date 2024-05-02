namespace Labor02._2
{
    internal class Program
    {
        public static Shape Legnagyobb(Shape[] s)
        {
            int maxIndex = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i].Area() > s[maxIndex].Area()) maxIndex = i; 
            }
            return s[maxIndex];
        }
        public static Shape Letrehoz(int a, int b)
        {
            if (a == b) return new Square(a, b);
            return new Rectangle(a, b);
        }
        public static void Kilyukaszt(Shape s)
        {
            if (s.Area() > s.Perimeter())
            {
                s.MakeHoley();
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Square s = new Square(10, 15);
            Circle c = new Circle(22);
            Console.WriteLine(r);
            Console.WriteLine(s);
            Console.WriteLine(c);

            Shape[] sikidomok = new Shape[]
            {
                new Circle(22),
                new Square(2, 5),
                new Rectangle(8, 12, "blue"),
                new Circle(6) 
            };
            
            Kilyukaszt(r);
            Console.Clear();

            foreach (Shape shape in sikidomok)
            {
                Console.WriteLine(shape.ToString());
            }

            Shape nagy = Legnagyobb(sikidomok);
            Console.WriteLine(nagy.Area());
        }
    }
}
