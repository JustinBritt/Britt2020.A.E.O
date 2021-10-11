namespace Britt2020.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IieCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IeIndexElement eIndexElement { get; }
    }
}