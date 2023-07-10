namespace Britt2022.A.E.O.InterfacesVisitors.Results.DayScenarioRecoveryWardCensuses
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;

    public interface IIOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IkIndexElement
        where TValue : RedBlackTree<IωIndexElement, IIResultElement>
    {
        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> RedBlackTree { get; }
    }
}
