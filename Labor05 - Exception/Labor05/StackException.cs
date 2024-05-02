using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor05
{
    public class StackException : Exception
    {
        IngredientStack stack;

        public StackException(IngredientStack stack) 
            : base("stack hiba tortent!")
        {
            this.stack = stack;
        }
    }
}
