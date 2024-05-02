using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor10
{
    public class PhoneBookItem : IComparable
    {
        public string Nev { get; set; }
        public int Telefonszam { get; set; }

        public int CompareTo(object? obj)
        {
            //EE
            if(!(obj is PhoneBookItem) && !(obj is string))
            {
                throw new ArgumentException();
            }

            if(obj is PhoneBookItem)
            {
                return this.Nev.CompareTo((obj as PhoneBookItem).Nev);
            }
            
            return this.Nev.CompareTo(obj as String);
        }
    }
}
