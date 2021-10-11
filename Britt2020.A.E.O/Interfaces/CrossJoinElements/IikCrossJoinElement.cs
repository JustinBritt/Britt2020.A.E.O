namespace Britt2020.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IikCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}