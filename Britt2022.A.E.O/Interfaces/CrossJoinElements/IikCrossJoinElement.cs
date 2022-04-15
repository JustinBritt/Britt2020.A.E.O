namespace Britt2022.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IikCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}