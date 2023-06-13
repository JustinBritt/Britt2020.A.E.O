namespace Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    public interface Ip
    {
        RedBlackTree<IiIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IpParameterElement>>> Value { get; }

        double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement);
    }
}