namespace Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonScenarioDeviations
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;

    public interface Id1PlusInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IωIndexElement
        where TValue : Id1PlusResultElement
    {
        RedBlackTree<INullableValue<int>, INullableValue<int>> RedBlackTree { get; }
    }
}