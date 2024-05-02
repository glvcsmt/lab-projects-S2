using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor02._3
{
    internal sealed class Owner
    {
        string name;

        public Owner(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
    }
}
