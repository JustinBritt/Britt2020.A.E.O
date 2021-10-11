namespace Britt2020.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IkωCrossJoinElement
    {
        IkIndexElement kIndexElement { get; }

        IωIndexElement ωIndexElement { get; }
    }
}