namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class ScenarioProbabilitiesVisitor<TKey, TValue> : IScenarioProbabilitiesVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioProbabilitiesVisitor(
            IΡParameterElementFactory ΡParameterElementFactory,
            Iω ω)
        {
            this.ΡParameterElementFactory = ΡParameterElementFactory;

            this.ω = ω;

            this.RedBlackTree = new RedBlackTree<IωIndexElement, IΡParameterElement>();
        }

        private IΡParameterElementFactory ΡParameterElementFactory { get; }

        private Iω ω { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IωIndexElement, IΡParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IωIndexElement ωIndexElement = this.ω.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                ωIndexElement,
                this.ΡParameterElementFactory.Create(
                    ωIndexElement,
                    obj.Value));
        }
    }
}