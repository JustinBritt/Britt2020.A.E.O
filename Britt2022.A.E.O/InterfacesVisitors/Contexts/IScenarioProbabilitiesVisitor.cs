namespace Britt2022.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IScenarioProbabilitiesVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        RedBlackTree<IωIndexElement, IΡParameterElement> RedBlackTree { get; }
    }
}