namespace Britt2020.A.E.O.Interfaces.CrossJoinElements
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IilωCrossJoinElement
    {
        IiIndexElement iIndexElement { get; }
        
        IlIndexElement lIndexElement { get; }
        
        IωIndexElement ωIndexElement { get; }
    }
}