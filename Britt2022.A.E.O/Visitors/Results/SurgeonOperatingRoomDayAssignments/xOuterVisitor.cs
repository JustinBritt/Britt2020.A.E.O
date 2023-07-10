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

    internal sealed class xOuterVisitor<TKey, TValue> : IxOuterVisitor<TKey, TValue>
        where TKey : IiIndexElement
        where TValue : RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.LocationComparer = locationComparer;

            this.OrganizationComparer = organizationComparer;

            this.RedBlackTree = new RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        private ILocationComparer LocationComparer { get; }

        private IOrganizationComparer OrganizationComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = obj.Key;

            RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>> value = obj.Value;

            IxFirstInnerVisitor<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>> innerVisitor = new xFirstInnerVisitor<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>(
                this.NullableValueFactory,
                this.FhirDateTimeComparer,
                this.LocationComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}