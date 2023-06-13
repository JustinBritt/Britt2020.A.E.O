namespace Britt2022.A.E.O.Interfaces.Parameters.Surgeries
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface In
    {
        RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, InParameterElement>> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);
    }
}