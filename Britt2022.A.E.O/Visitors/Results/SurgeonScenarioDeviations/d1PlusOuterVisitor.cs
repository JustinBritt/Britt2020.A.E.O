namespace Britt2022.A.E.O.Visitors.Results.SurgeonScenarioDeviations
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonScenarioDeviations;

    internal sealed class d1PlusOuterVisitor<TKey, TValue> : Id1PlusOuterVisitor<TKey, TValue>
        where TKey : IiIndexElement
        where TValue : RedBlackTree<IωIndexElement, Id1PlusResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1PlusOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            INullableValueintComparer nullableValueintComparer,
            IOrganizationComparer organizationComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = redBlackTreeFactory.Create<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                organizationComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = obj.Key;

            RedBlackTree<IωIndexElement, Id1PlusResultElement> value = obj.Value;

            Id1PlusInnerVisitor<IωIndexElement, Id1PlusResultElement> innerVisitor = new d1PlusInnerVisitor<IωIndexElement, Id1PlusResultElement>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}