using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_exam_practise
{
    public class Time : IComparable
    {
        int hour;
        int min;
        int sec;

        public int Hour
        {
            get => hour;
            set
            {
                if (value < 0 || value > 3) throw new TimeException($"Value of hour cannot be {value}.");
                hour = value;
            }
        }

        public int Min
        {
            get => min;
            set
            {
                if (value < 0 || value > 59) throw new TimeException($"Value of minute cannot be {value}.");
                min = value;
            }
        }

        public int Sec
        {
            get => sec;
            set
            {
                if (value < 0 || value > 59) throw new TimeException($"Value of second cannot be {value}.");
                sec = value;
            }
        }

        public Time(int hour, int min, int sec)
        {
            Hour = hour;
            Min = min;
            Sec = sec;
        }

        public Time(int min, int sec) : this(0, min, sec){}

        public override string? ToString()
        {
            if (this.hour == 0) return $"{min:00}:{sec:00}";
            else return $"{hour:00}:{min:00}:{sec:00}";
        }

        public static Time Parse(string input)
        {
            string[] temp = input.Split(":");
            if (temp.Length == 3 && input.Length == 8) return new Time(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
            else if (temp.Length == 2 && input.Length == 5) return new Time(int.Parse(temp[0]), int.Parse(temp[1]));
            throw new TimeException($"{input} cannot be parsed as a Time object.");
        }

        public override bool Equals(object? obj)
        {
            if(obj  == null) throw new ArgumentNullException();
            return obj is Time other && hour == other.hour && min == other.min && sec == other.sec;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) throw new ArgumentNullException();
            if (!(obj is Time)) throw new ArgumentException();

            Time temp = obj as Time;
            if (Equals(temp)) return 0;
            if(hour.CompareTo(temp.hour) != 0) return hour.CompareTo(temp.hour);
            else if(min.CompareTo(temp.min) != 0) return min.CompareTo(temp.min);
            return sec.CompareTo(temp.sec);
        }
    }
}
