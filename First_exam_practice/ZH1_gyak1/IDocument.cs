using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public interface IDocument
    {
        public string Name { get; }
        public int PassportNumber { get; }

        bool isNotExpired(DateTime date);
    }
}
