namespace Britt2022.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IjkCrossJoinElement
    {
        IjIndexElement jIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}