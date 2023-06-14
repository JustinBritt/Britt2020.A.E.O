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

    internal sealed class SurgicalSpecialtyStrategicTargetNumberTimeBlocksVisitor<TKey, TValue> : ISurgicalSpecialtyStrategicTargetNumberTimeBlocksVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyStrategicTargetNumberTimeBlocksVisitor(
            IBParameterElementFactory BParameterElementFactory,
            Ir r)
        {
            this.BParameterElementFactory = BParameterElementFactory;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, IBParameterElement>();
        }

        private IBParameterElementFactory BParameterElementFactory { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, IBParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                rIndexElement,
                this.BParameterElementFactory.Create(
                    rIndexElement,
                    obj.Value));
        }
    }
}