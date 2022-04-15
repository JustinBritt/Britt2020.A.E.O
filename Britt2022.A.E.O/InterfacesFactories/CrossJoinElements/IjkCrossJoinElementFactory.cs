namespace Britt2022.A.E.O.InterfacesFactories.CrossJoinElements
{
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IjkCrossJoinElementFactory
    {
        IjkCrossJoinElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement);
    }
}