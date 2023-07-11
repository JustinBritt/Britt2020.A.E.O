namespace Britt2022.A.E.O.Visitors.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2MinusOuterVisitor<TKey, TValue> : Id2MinusOuterVisitor<TKey, TValue>
        where TKey : IiIndexElement
        where TValue : RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2MinusOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer,
            INullableValueintComparer nullableValueintComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.LocationComparer = locationComparer;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = redBlackTreeFactory.Create<Organization, RedBlackTree <Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> (
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        private ILocationComparer LocationComparer { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = obj.Key;

            RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>> value = obj.Value;

            Id2MinusFirstInnerVisitor<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>> innerVisitor = new d2MinusFirstInnerVisitor<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.FhirDateTimeComparer,
                this.LocationComparer,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}