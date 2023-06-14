namespace Britt2022.A.E.O.InterfacesFactories.Parameters.LengthsOfStay
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    public interface IhFactory
    {
        Ih Create(
            RedBlackTree<IiIndexElement, IhParameterElement> value);
    }
}