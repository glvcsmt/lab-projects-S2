using System.Runtime.Serialization;

namespace ZH1_gyak1
{
    [Serializable]
    public class NameErrorException : DocumentProblemException
    {
        public NameErrorException(IDocument document) : base(document)
        {
        }
    }
}