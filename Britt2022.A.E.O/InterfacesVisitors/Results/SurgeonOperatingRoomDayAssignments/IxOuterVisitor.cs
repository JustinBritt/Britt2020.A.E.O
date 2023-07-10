namespace Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    public interface IxOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : IiIndexElement
        where TValue : RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>
    {
        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> RedBlackTree { get; }
    }
}