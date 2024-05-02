using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor05
{
    public class IngredientStackHandler
    {
        IngredientStack verem;

        public IngredientStackHandler(IngredientStack verem)
        {
            this.verem = verem;
        }

        public FoodIngredient[] AddItems(FoodIngredient[] foodIngredients)
        {
            if (foodIngredients.Length <= verem.Meret)
            {
                foreach (FoodIngredient item in foodIngredients)
                {
                    this.verem.Push(item);
                }
                return null;
            }

            if (foodIngredients.Length > this.verem.Meret)
            {
                FoodIngredient[] result = new FoodIngredient[foodIngredients.Length - this.verem.Meret];
                int idx = 0;
                foreach (FoodIngredient item in foodIngredients)
                {
                    try
                    {
                        this.verem.Push(item);
                    }
                    catch (StackFullException ex)
                    {

                        //result[idx++] = item;
                        result[idx++] = ex.NemMentBele;
                    }
                }
                return result;
            }
            return null;
        }
    }
}
