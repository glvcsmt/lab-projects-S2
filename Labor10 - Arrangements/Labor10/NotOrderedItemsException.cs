using System.Runtime.Serialization;

namespace Labor10
{
    [Serializable]
    public class NotOrderedItemsException : Exception
    {
        IComparable[] Tomb;

        public NotOrderedItemsException(IComparable[] tomb)
        {
            Tomb = tomb;
        }
    }
}