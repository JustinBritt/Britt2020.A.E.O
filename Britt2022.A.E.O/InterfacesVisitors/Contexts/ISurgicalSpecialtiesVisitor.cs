namespace Britt2022.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface ISurgicalSpecialtiesVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : IImmutableSet<Organization>
    {
        RedBlackTree<IrIndexElement, ImmutableList<IiIndexElement>> RedBlackTree { get; }

        List<ISParameterElement> Value { get; }
    }
}