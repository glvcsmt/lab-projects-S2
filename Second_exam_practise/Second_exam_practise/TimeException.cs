using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_exam_practise
{
    public class TimeException : Exception
    {
        public TimeException(string? message) : base(message)
        {
        }
    }
}
