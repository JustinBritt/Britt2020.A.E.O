namespace Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    public interface IxFirstInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IjIndexElement
        where TValue : RedBlackTree<IkIndexElement, IxResultElement>
    {
        RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> RedBlackTree { get; }
    }
}