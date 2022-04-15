namespace Britt2022.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IieCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IeIndexElement eIndexElement { get; }
    }
}