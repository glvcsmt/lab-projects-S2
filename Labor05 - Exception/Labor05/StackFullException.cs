using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor05
{
    public class StackFullException : StackException
    {
        FoodIngredient nemMentBele;
        public StackFullException(IngredientStack stack, FoodIngredient m) 
            : base(stack)
        {
            this.nemMentBele = m;
        }

        public FoodIngredient NemMentBele { get => nemMentBele; }
    }
}
