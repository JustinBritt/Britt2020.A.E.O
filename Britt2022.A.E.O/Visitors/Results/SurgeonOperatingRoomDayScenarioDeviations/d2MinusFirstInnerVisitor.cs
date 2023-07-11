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

    internal sealed class d2MinusFirstInnerVisitor<TKey, TValue> : Id2MinusFirstInnerVisitor<TKey, TValue>
        where TKey : IjIndexElement
        where TValue : RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2MinusFirstInnerVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            ILocationComparer locationComparer,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.FhirDateTimeComparer = FhirDateTimeComparer;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = redBlackTreeFactory.Create<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>(
                locationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private IFhirDateTimeComparer FhirDateTimeComparer { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IjIndexElement iIndexElement = obj.Key;

            RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>> value = obj.Value;

            Id2MinusSecondInnerVisitor<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>> innerVisitor = new d2MinusSecondInnerVisitor<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.FhirDateTimeComparer,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}