using System.Runtime.Serialization;

namespace ZH1_gyak1
{
    [Serializable]
    public class InvalidDocumentException : DocumentProblemException
    {
        public InvalidDocumentException(IDocument document) : base(document)
        {
        }
    }
}