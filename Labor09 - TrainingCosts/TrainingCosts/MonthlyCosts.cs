using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCosts
{
    public class MonthlyCosts
    {
        public TrainingCost[] TrainingCosts { get; set; }

        public static MonthlyCosts LoadFrom(string filename)
        {
            if (!File.Exists(filename)) throw new FileNotFoundException();

            MonthlyCosts result = new MonthlyCosts();
            result.TrainingCosts = new TrainingCost[FileLength(filename)];

            using (StreamReader sr = new StreamReader(filename))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    result.TrainingCosts[i] = TrainingCost.Parse(line);
                    ++i;
                }
            }

            return result;
        }

        private static int FileLength(string filename)
        {
            return File.ReadAllLines(filename).Length;
        }

        //Teljes költés egy éven belül
        public int TeljesKoltes()
        {
            int sum = 0;
            foreach (TrainingCost item in TrainingCosts)
            {
                sum += item.Cost;
            }
            return sum;
        }

        //Teljes költés feltétellel
        public int TeljesKoltes(Predicate<TrainingCost> pre)
        {
            int sum = 0;
            foreach (TrainingCost item in TrainingCosts)
            {
                if(pre(item) == true) sum += item.Cost;
            }
            return sum;
        }
        
        //Volt-e adott feltetelnek megfelelo koltes
        public bool VoltE(Predicate<TrainingCost> pre)
        {
            //EX
            foreach(TrainingCost item in TrainingCosts)
            {
                if (pre(item)) return true;
            }
            return false;
        }

        //Legalabb k db adott feltetelu koltes
        public bool LegalabbK(Predicate<TrainingCost> pre, int k)
        {
            int sum = 0;
            foreach (TrainingCost item in TrainingCosts)
            {
                if (pre(item)) sum++;
            }
            if(sum >= k) return true;
            return false;
        }

        //K-adik felteteles koltes
        public string KFeletetel(Predicate<TrainingCost> pre, int k)
        {
            List<TrainingCost> temp = new List<TrainingCost> ();
            foreach(TrainingCost item in TrainingCosts)
            {
                if(pre(item)) temp.Add(item);
            }

            if (temp.Count >= k) return temp[k-1].Description;
            return "null";
        }

        //Mennyi K feltetelu koltes
        public int FeltetelesKoltesDb(Predicate<TrainingCost> pre)
        {
            int sum = 0;
            foreach (TrainingCost item in TrainingCosts)
            {
                if(pre(item)) sum++;
            }
            return sum;
        }

        //Max of koltes
        public int MaxKoltes()
        {
            int max = 0;
            for (int i = 0; i < TrainingCosts.Length; i++)
            {
                if (TrainingCosts[i].Cost > max) max = TrainingCosts[i].Cost;
            }
            if (max == 0) throw new ZeroLengthArrayException();
            return max;
        }

        public int[] MaxIndexek()
        {
            int[] result = new int[TrainingCosts.Length];
            
            int db = 0; //result tomb indexelese

            result[db] = 0;

            for (int i = 0; i < TrainingCosts.Length; i++)
            {
                if (TrainingCosts[i].Cost > TrainingCosts[result[0]].Cost)
                {
                    result[0] = i;
                    db = 0;
                }
                else if (TrainingCosts[i].Cost == TrainingCosts[result[0]].Cost)
                {
                    result[++db] = i;
                }
            }
            Array.Resize(ref result, db + 1);
            return result;
        }
    }
}
