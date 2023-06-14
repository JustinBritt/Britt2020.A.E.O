namespace Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;

    public interface IL
    {
        RedBlackTree<IiIndexElement, ILParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);
    }
}