using System.Runtime.Serialization;

namespace ZH1_GMG
{
    [Serializable]
    internal class NoMorePortException : Exception
    {
        IAircraft airplane;

        public NoMorePortException(IAircraft airplane)
        {
            this.airplane = airplane;
        }
    }
}