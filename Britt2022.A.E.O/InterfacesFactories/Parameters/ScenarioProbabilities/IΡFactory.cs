namespace Britt2022.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    public interface IΡFactory
    {
        IΡ Create(
            RedBlackTree<IωIndexElement, IΡParameterElement> value);
    }
}