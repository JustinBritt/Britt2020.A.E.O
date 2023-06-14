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

    internal sealed class SurgeonMaximumNumberTimeBlocksVisitor<TKey, TValue> : ISurgeonMaximumNumberTimeBlocksVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonMaximumNumberTimeBlocksVisitor(
            IHParameterElementFactory HParameterElementFactory,
            Ii i)
        {
            this.HParameterElementFactory = HParameterElementFactory;

            this.i = i;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, IHParameterElement>();
        }

        private IHParameterElementFactory HParameterElementFactory { get; }

        private Ii i { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, IHParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                iIndexElement,
                this.HParameterElementFactory.Create(
                    iIndexElement,
                    obj.Value));
        }
    }
}