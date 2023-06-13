namespace Britt2022.A.E.O.InterfacesFactories.Parameters.Surgeries
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface IAFactory
    {
        IA Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, IAParameterElement>> value);
    }
}