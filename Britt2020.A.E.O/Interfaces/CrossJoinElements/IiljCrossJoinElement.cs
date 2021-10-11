namespace Britt2020.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IiljCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        IjIndexElement jIndexElement { get; }
    }
}