namespace Britt2022.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2Minus : Id2Minus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2Minus(
            VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement, IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement, IωIndexElement> Value { get; }

        public decimal GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement)
        {
            return (decimal)this.Value[iIndexElement, jIndexElement, kIndexElement, ωIndexElement].Value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations.Id2Minus GetElementsAt(
            Id2MinusResultElementFactory d2MinusResultElementFactory,
            Id2MinusFactory d2MinusFactory,
            Ii i,
            Ij j,
            Ik k,
            Iω ω)
        {
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>> outerRedBlackTree = new RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>>();

            foreach (IiIndexElement iIndexElement in i.Value.Values)
            {
                RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>> firstInnerRedBlackTree = new RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>();

                foreach (IjIndexElement jIndexElement in j.Value.Values)
                {
                    RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>> secondInnerRedBlackTree = new RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>();

                    foreach (IkIndexElement kIndexElement in k.Value)
                    {
                        RedBlackTree<IωIndexElement, Id2MinusResultElement> thirdInnerRedBlackTree = new RedBlackTree<IωIndexElement, Id2MinusResultElement>();

                        foreach (IωIndexElement ωIndexElement in ω.Value.Values)
                        {
                            thirdInnerRedBlackTree.Add(
                                ωIndexElement,
                                d2MinusResultElementFactory.Create(
                                    iIndexElement,
                                    jIndexElement,
                                    kIndexElement,
                                    ωIndexElement,
                                    this.GetElementAt(
                                        iIndexElement,
                                        jIndexElement,
                                        kIndexElement,
                                        ωIndexElement)));
                        }

                        secondInnerRedBlackTree.Add(
                            kIndexElement,
                            thirdInnerRedBlackTree);

                    }

                    firstInnerRedBlackTree.Add(
                        jIndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    iIndexElement,
                    firstInnerRedBlackTree);
            }

            return d2MinusFactory.Create(
                outerRedBlackTree);
        }
    }
}