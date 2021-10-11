namespace Britt2020.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IieωCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IeIndexElement eIndexElement { get; }

        IωIndexElement ωIndexElement { get; }
    }
}