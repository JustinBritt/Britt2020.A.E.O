namespace Britt2020.A.E.O.InterfacesFactories.CrossJoinElements
{
    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IiljCrossJoinElementFactory
    {
        IiljCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IjIndexElement jIndexElement);
    }
}