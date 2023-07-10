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

    internal sealed class d1Plus : Id1Plus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Plus(
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

        public Interfaces.Results.SurgeonScenarioDeviations.Id1Plus GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            Id1PlusResultElementFactory d1PlusResultElementFactory,
            Id1PlusFactory d1PlusFactory,
            Ii i,
            Iω ω)
        {
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>> outerRedBlackTree = redBlackTreeFactory.Create<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>>();

            foreach (IiIndexElement iIndexElement in i.Value.Values)
            {
                RedBlackTree<IωIndexElement, Id1PlusResultElement> innerRedBlackTree = redBlackTreeFactory.Create<IωIndexElement, Id1PlusResultElement>();

                foreach (IωIndexElement ωIndexElement in ω.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ωIndexElement,
                        d1PlusResultElementFactory.Create(
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

            return d1PlusFactory.Create(
                outerRedBlackTree);
        }
    }
}