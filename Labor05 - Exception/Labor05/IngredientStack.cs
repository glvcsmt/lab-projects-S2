using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Labor05
{
    public class IngredientStack
    {
        FoodIngredient[] tomb;

        //utolso tartolt elem indexe
        int idx = -1;

        public int Meret
        {
            get {
                return this.tomb.Length;
            }
        }

        public IngredientStack(int meret)
        {
            this.tomb = new FoodIngredient[meret];
        }

        public bool Empty()
        {
            return idx == -1;
        }

        public void Push(FoodIngredient newItem)
        {
            //ha inx == utolso tombbeli eleme
            if(idx == tomb.Length-1)
            {
                throw new StackFullException(this, newItem);
            }

            //mehet
            this.tomb[++idx] = newItem;
        }

        public FoodIngredient Pop()
        {
            if(this.Empty() == true)
            {
                throw new StackEmptyException(this);
            }
            
            return this.tomb[idx--];
        }

        public FoodIngredient Top()
        {
            if (this.Empty()) return null;

            return this.tomb[idx];
        }
    }
}
