namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor<TKey, TValue> : ISurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayScenarioLengthOfStayProbabilitiesSecondInnerVisitor(
            IpParameterElementFactory pParameterElementFactory,
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            Iω ω)
        {
            this.pParameterElementFactory = pParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.ω = ω;

            this.RedBlackTree = new RedBlackTree<IωIndexElement, IpParameterElement>();
        }

        private IpParameterElementFactory pParameterElementFactory { get; }

        private IiIndexElement iIndexElement { get; }

        private IlIndexElement lIndexElement { get; }

        private Iω ω { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IωIndexElement, IpParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IωIndexElement ωIndexElement = this.ω.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ωIndexElement,
                this.pParameterElementFactory.Create(
                    this.iIndexElement,
                    this.lIndexElement,
                    ωIndexElement,
                    obj.Value));
        }
    }
}