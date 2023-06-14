namespace Britt2022.A.E.O.InterfacesFactories.Parameters.StrategicTargets
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;

    public interface IBFactory
    {
        IB Create(
            RedBlackTree<IrIndexElement, IBParameterElement> value);
    }
}