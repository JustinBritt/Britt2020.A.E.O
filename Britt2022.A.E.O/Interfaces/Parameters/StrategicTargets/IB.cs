namespace Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;

    public interface IB
    {
        RedBlackTree<IrIndexElement, IBParameterElement> Value { get; }

        int GetElementAtAsint(
            IrIndexElement rIndexElement);
    }
}