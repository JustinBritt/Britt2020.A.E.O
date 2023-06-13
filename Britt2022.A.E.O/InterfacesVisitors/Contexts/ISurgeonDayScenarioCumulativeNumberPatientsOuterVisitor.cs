namespace Britt2022.A.E.O.InterfacesVisitors.Contexts
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    public interface ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>
    {
        RedBlackTree<IiIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IΦParameterElement>>> RedBlackTree { get; }
    }
}