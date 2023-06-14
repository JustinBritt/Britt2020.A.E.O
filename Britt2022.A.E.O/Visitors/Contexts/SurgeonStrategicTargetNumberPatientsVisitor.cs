namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonStrategicTargetNumberPatientsVisitor<TKey, TValue> : ISurgeonStrategicTargetNumberPatientsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonStrategicTargetNumberPatientsVisitor(
            INParameterElementFactory NParameterElementFactory,
            Ii i)
        {
            this.NParameterElementFactory = NParameterElementFactory;

            this.i = i;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, INParameterElement>();
        }

        private INParameterElementFactory NParameterElementFactory { get; }

        private Ii i { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, INParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                iIndexElement,
                this.NParameterElementFactory.Create(
                    iIndexElement,
                    obj.Value));
        }
    }
}