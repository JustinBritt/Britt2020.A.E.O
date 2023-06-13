namespace Britt2022.A.E.O.Interfaces.Parameters.Surgeries
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface IA
    {
        RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, IAParameterElement>> Value { get; }

        decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);

        double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);
    }
}