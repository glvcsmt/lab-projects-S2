namespace Labor05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Nem jo szam formatum!");
            }
            catch (Exception)
            {
                Console.WriteLine("Valami hiba van!");
            }*/

            /*IngredientStack stack = new IngredientStack(2);

            FoodIngredient f1 = new FoodIngredient("liszt", 3, Egyseg.kilogramm);
            try
            {
                stack.Pop();

                stack.Push(f1);
                stack.Push(f1);
                stack.Push(f1);
            }
            catch (StackFullException)
            {
                Console.WriteLine("Tele van a stack...");
            }
            catch (StackEmptyException)
            {
                Console.WriteLine("Ures a stack...");
            }

            Console.WriteLine("EOF");*/

            IngredientStack stack = new IngredientStack(2);

            FoodIngredient[] food = new FoodIngredient[]
            {
                new FoodIngredient("liszt", 3, Egyseg.kilogramm),
                new FoodIngredient("vaj", 3, Egyseg.kilogramm),
                new FoodIngredient("tej", 3, Egyseg.kilogramm),
                new FoodIngredient("zsemle", 3, Egyseg.kilogramm),
                new FoodIngredient("kolbasz", 3, Egyseg.kilogramm)
            };

            IngredientStackHandler handler = new IngredientStackHandler(stack);

            FoodIngredient[] nemFertBele = handler.AddItems(food);
           
        }
    }
}