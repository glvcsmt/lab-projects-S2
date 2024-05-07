using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_exam_practise
{
    internal class RunnerWithTime : IComparable
    {
        public string Name { get; protected set; }
        public Time TimeResult { get; protected set; }

        public static RunnerWithTime Parse(string input)
        {
            string[] nameAndTime = input.Split(',');
            
            RunnerWithTime runner = new RunnerWithTime();
            runner.Name = nameAndTime[0];
            runner.TimeResult = Time.Parse(nameAndTime[1]);
            return runner;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) throw new ArgumentNullException();
            if (!(obj is RunnerWithTime)) throw new ArgumentException();

            RunnerWithTime temp = obj as RunnerWithTime;
            if(this.TimeResult.Equals(temp.TimeResult)) return this.Name.CompareTo(temp.Name);
            else return this.TimeResult.CompareTo(temp.TimeResult);
        }

        public override string? ToString()
        {   
            if(this.TimeResult.Hour == 0) return $"{this.Name} ({this.TimeResult.Min:00}:{this.TimeResult.Sec:00})";
            else return $"{this.Name} ({this.TimeResult.Hour:00}:{this.TimeResult.Min:00}:{this.TimeResult.Sec:00})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException();
            return obj is RunnerWithTime temp && temp.Name.Equals(this.Name) && temp.TimeResult.Equals(this.TimeResult);
        }
    }
}
