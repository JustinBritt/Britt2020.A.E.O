namespace Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IΡ
    {
        RedBlackTree<IωIndexElement, IΡParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IωIndexElement ωIndexElement);
    }
}