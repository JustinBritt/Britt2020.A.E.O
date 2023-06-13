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

    internal sealed class SurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue> : ISurgeonScenarioMaximumNumberPatientsInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioMaximumNumberPatientsInnerVisitor(
            InParameterElementFactory nParameterElementFactory,
            IiIndexElement iIndexElement,
            Iω ω)
        {
            this.nParameterElementFactory = nParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.ω = ω;

            this.RedBlackTree = new RedBlackTree<IωIndexElement, InParameterElement>();
        }

        private InParameterElementFactory nParameterElementFactory { get; }

        private IiIndexElement iIndexElement { get; }

        private Iω ω { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IωIndexElement, InParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IωIndexElement ωIndexElement = this.ω.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ωIndexElement,
                this.nParameterElementFactory.Create(
                    this.iIndexElement,
                    ωIndexElement,
                    obj.Value));
        }
    }
}