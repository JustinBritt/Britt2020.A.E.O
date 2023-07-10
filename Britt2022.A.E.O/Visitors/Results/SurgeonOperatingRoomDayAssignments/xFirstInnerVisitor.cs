namespace Britt2022.A.E.O.Visitors.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class xFirstInnerVisitor<TKey, TValue> : IxFirstInnerVisitor<TKey, TValue>
        where TKey : IjIndexElement
        where TValue : RedBlackTree<IkIndexElement, IxResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xFirstInnerVisitor(
            INullableValueFactory nullableValueFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.RedBlackTree = new RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        private IOrganizationComparer OrganizationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IjIndexElement jIndexElement = obj.Key;

            RedBlackTree<IkIndexElement, IxResultElement> value = obj.Value;

            IxSecondInnerVisitor<IkIndexElement, IxResultElement> innerVisitor = new xSecondInnerVisitor<IkIndexElement, IxResultElement>(
                this.NullableValueFactory,
                this.FhirDateTimeComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                jIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}