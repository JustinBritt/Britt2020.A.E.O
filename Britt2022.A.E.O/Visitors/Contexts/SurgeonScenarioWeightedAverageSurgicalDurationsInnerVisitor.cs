namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor<TKey, TValue> : ISurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : Duration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioWeightedAverageSurgicalDurationsInnerVisitor(
            IAParameterElementFactory AParameterElementFactory,
            IiIndexElement iIndexElement,
            Iω ω)
        {
            this.AParameterElementFactory = AParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.ω = ω;

            this.RedBlackTree = new RedBlackTree<IωIndexElement, IAParameterElement>();
        }

        private IAParameterElementFactory AParameterElementFactory { get; }

        private IiIndexElement iIndexElement { get; }

        private Iω ω { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IωIndexElement, IAParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IωIndexElement ωIndexElement = this.ω.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ωIndexElement,
                this.AParameterElementFactory.Create(
                    this.iIndexElement,
                    ωIndexElement,
                    obj.Value));
        }
    }
}