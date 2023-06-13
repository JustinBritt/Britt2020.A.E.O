namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor(
            IΦParameterElementFactory ΦParameterElementFactory,
            IiIndexElement iIndexElement,
            Il l,
            Iω ω)
        {
            this.ΦParameterElementFactory = ΦParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.l = l;

            this.ω = ω;

            this.RedBlackTree = new RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IΦParameterElement>>();
        }

        private IΦParameterElementFactory ΦParameterElementFactory { get; }

        private IiIndexElement iIndexElement { get; }

        private Il l { get; }

        private Iω ω { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IΦParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IlIndexElement lIndexElement = this.l.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            var innerVisitor = new SurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.ΦParameterElementFactory,
                iIndexElement,
                lIndexElement,
                this.ω);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                lIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}