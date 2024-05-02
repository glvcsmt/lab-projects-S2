using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public class ExpiredPassportException : DocumentProblemException
    {
        public ExpiredPassportException(IDocument document) : base(document)
        {
        }
    }
}
