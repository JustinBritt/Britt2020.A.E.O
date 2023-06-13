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

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioCumulativeNumberPatientsOuterVisitor(
            IΦParameterElementFactory ΦParameterElementFactory,
            Ii i,
            Il l,
            Iω ω)
        {
            this.ΦParameterElementFactory = ΦParameterElementFactory;

            this.i = i;

            this.l = l;

            this.ω = ω;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IΦParameterElement>>>();
        }

        private IΦParameterElementFactory ΦParameterElementFactory { get; }

        private Ii i { get; }

        private Il l { get; }

        private Iω ω { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IΦParameterElement>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> value = obj.Value;

            var innerVisitor = new SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                this.ΦParameterElementFactory,
                iIndexElement,
                this.l,
                this.ω);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}