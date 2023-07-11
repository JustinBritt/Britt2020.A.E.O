namespace Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2MinusThirdInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IωIndexElement
        where TValue : Id2MinusResultElement
    {
        RedBlackTree<INullableValue<int>, INullableValue<decimal>> RedBlackTree { get; }
    }
}