namespace Britt2022.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IijCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }

        IjIndexElement jIndexElement { get; }
    }
}