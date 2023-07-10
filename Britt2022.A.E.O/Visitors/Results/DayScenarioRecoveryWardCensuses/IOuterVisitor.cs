namespace Britt2022.A.E.O.Visitors.Results.DayScenarioRecoveryWardCensuses
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesVisitors.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IOuterVisitor<TKey, TValue> : IIOuterVisitor<TKey, TValue>
        where TKey : IkIndexElement
        where TValue : RedBlackTree<IωIndexElement, IIResultElement>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IOuterVisitor(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IFhirDateTimeComparer FhirDateTimeComparer,
            INullableValueintComparer nullableValueintComparer)
        {
            this.NullableValueFactory = nullableValueFactory;

            this.RedBlackTreeFactory = redBlackTreeFactory;

            this.NullableValueintComparer = nullableValueintComparer;

            this.RedBlackTree = redBlackTreeFactory.Create<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                FhirDateTimeComparer);
        }

        private INullableValueFactory NullableValueFactory { get; }

        private IRedBlackTreeFactory RedBlackTreeFactory { get; }

        private INullableValueintComparer NullableValueintComparer { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IkIndexElement kIndexElement = obj.Key;

            RedBlackTree<IωIndexElement, IIResultElement> value = obj.Value;

            IIInnerVisitor<IωIndexElement, IIResultElement> innerVisitor = new IInnerVisitor<IωIndexElement, IIResultElement>(
                this.NullableValueFactory,
                this.RedBlackTreeFactory,
                this.NullableValueintComparer);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                kIndexElement.Value,
                innerVisitor.RedBlackTree);
        }
    }
}