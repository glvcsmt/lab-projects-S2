using System.Runtime.Serialization;

namespace ZH1_gyak1
{
    [Serializable]
    public class PassportNumberErrorException : DocumentProblemException
    {
        public PassportNumberErrorException(IDocument document) : base(document)
        {
        }
    }
}