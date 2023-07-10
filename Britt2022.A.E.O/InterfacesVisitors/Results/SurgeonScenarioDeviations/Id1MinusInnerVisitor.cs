namespace Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonScenarioDeviations
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
   
    public interface Id1MinusInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IωIndexElement
        where TValue : Id1MinusResultElement
    {
        RedBlackTree<INullableValue<int>, INullableValue<int>> RedBlackTree { get; }
    }
}