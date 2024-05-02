using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public class InvalidBirthdateException : Exception
    {
        public InvalidBirthdateException(string? message) : base(message)
        {
        }
    }
}
