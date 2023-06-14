namespace Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    public interface Ih
    {
        RedBlackTree<IiIndexElement, IhParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);
    }
}