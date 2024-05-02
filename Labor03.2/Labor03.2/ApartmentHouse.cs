using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labor03._2
{
    internal class ApartmentHouse
    {
        public static IRealEstate[] LoadFromFile(string fajlnev)
        {
            string[] sorok = File.ReadAllLines(fajlnev);

            /*IRealEstate[] temp = new IRealEstate()*/
        }
        public IRealEstate[] Tarolo { get; private set; }

        int dbLakas;
        int dbGarazs;

        int maxLakas;
        int maxGarazs;

        public ApartmentHouse(int maxLakas, int maxGarazs)
        {
            this.dbLakas = 0;
            this.dbGarazs = 0;

            this.maxLakas = maxLakas;
            this.maxGarazs = maxGarazs;

            this.Tarolo = new IRealEstate[maxLakas + maxGarazs];
        }

        public bool Felvetel(IRealEstate obj)
        {
            if(obj is Flat)
            {
                //meg lehet lakas
                if(this.dbLakas < this.maxLakas)
                {
                    Tarolo[this.dbLakas + dbGarazs] = obj;
                    this.dbLakas++;
                    return true;
                }
            }
            if (obj is Garage)
            {
                //meg lehet garazs
                if (this.dbGarazs < this.maxGarazs)
                {
                    Tarolo[this.dbLakas + dbGarazs] = obj;
                    this.dbGarazs++;
                    return true;
                }
            }
            return false;
        }
    }
}
