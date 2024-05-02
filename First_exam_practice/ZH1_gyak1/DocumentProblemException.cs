using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public class DocumentProblemException : Exception
    {
        IDocument document;
        public DocumentProblemException(IDocument document)
        {
            this.document = document;
        }
    }
}
