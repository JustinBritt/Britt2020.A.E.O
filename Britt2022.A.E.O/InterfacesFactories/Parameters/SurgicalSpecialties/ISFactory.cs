namespace Britt2022.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface ISFactory
    {
        IS Create(
            RedBlackTree<IrIndexElement, ImmutableList<IiIndexElement>> redBlackTree,
            ImmutableList<ISParameterElement> value);
    }
}