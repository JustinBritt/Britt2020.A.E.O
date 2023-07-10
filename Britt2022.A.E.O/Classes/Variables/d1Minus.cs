namespace Britt2022.A.E.O.Classes.Variables
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;
    
    internal sealed class d1Minus : Id1Minus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Minus(
            VariableCollection<IiIndexElement, IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IωIndexElement> Value { get; }

        public int GetElementAt(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[iIndexElement, ωIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[iIndexElement, ωIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.SurgeonScenarioDeviations.Id1Minus GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            Id1MinusResultElementFactory d1MinusResultElementFactory,
            Id1MinusFactory d1MinusFactory,
            Ii i,
            Iω ω)
        {
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, Id1MinusResultElement>> outerRedBlackTree = redBlackTreeFactory.Create<IiIndexElement, RedBlackTree<IωIndexElement, Id1MinusResultElement>>();

            foreach (IiIndexElement iIndexElement in i.Value.Values)
            {
                RedBlackTree<IωIndexElement, Id1MinusResultElement> innerRedBlackTree = redBlackTreeFactory.Create<IωIndexElement, Id1MinusResultElement>();

                foreach (IωIndexElement ωIndexElement in ω.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ωIndexElement,
                        d1MinusResultElementFactory.Create(
                            iIndexElement,
                            ωIndexElement,
                            this.GetElementAt(
                                iIndexElement,
                                ωIndexElement)));
                }

                outerRedBlackTree.Add(
                    iIndexElement,
                    innerRedBlackTree);
            }

            return d1MinusFactory.Create(
                outerRedBlackTree);
        }
    }
}