using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor05
{
    public class StackEmptyException : StackException
    {
        public StackEmptyException(IngredientStack stack) 
            : base(stack)
        {
        }
    }
}
