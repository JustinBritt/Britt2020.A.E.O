namespace Britt2022.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;
    
    internal sealed class I : II
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public I(
            VariableCollection<IkIndexElement, IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IkIndexElement, IωIndexElement> Value { get; }

        public decimal GetElementAt(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement)
        {
            return (decimal)this.Value[kIndexElement, ωIndexElement].Value;
        }

        public Interfaces.Results.DayScenarioRecoveryWardCensuses.II GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IIResultElementFactory IResultElementFactory,
            IIFactory IFactory,
            Ik k,
            Iω ω)
        {
            RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>> outerRedBlackTree = redBlackTreeFactory.Create<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>>();

            foreach (IkIndexElement kIndexElement in k.Value)
            {
                RedBlackTree<IωIndexElement, IIResultElement> innerRedBlackTree = redBlackTreeFactory.Create<IωIndexElement, IIResultElement>();

                foreach (IωIndexElement ωIndexElement in ω.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ωIndexElement,
                        IResultElementFactory.Create(
                            kIndexElement,
                            ωIndexElement,
                            this.GetElementAt(
                                kIndexElement,
                                ωIndexElement)));
                }

                outerRedBlackTree.Add(
                    kIndexElement,
                    innerRedBlackTree);
            }

            return IFactory.Create(
                outerRedBlackTree);
        }
    }
}