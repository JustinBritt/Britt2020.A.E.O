namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<TKey, TValue> : ISurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, Duration>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor(
            IAParameterElementFactory AParameterElementFactory,
            Ii i,
            Iω ω)
        {
            this.AParameterElementFactory = AParameterElementFactory;

            this.i = i;

            this.ω = ω;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, IAParameterElement>>();
        }

        private IAParameterElementFactory AParameterElementFactory { get; }

        private Ii i { get; }

        private Iω ω { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, IAParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, Duration> value = obj.Value;

            var innerVisitor = new SurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor<INullableValue<int>, Duration>(
                this.AParameterElementFactory,
                iIndexElement,
                this.ω);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}