namespace Britt2022.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
    
    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement> Value { get; }

        public bool GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            bool value = false;

            if (this.Value[iIndexElement, jIndexElement, kIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Ii i,
            Ij j,
            Ik k)
        {
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>> outerRedBlackTree = new RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>>();

            foreach (IiIndexElement iIndexElement in i.Value.Values)
            {
                RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>> firstInnerRedBlackTree = new RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>();

                foreach (IjIndexElement jIndexElement in j.Value.Values)
                {
                    RedBlackTree<IkIndexElement, IxResultElement> secondInnerRedBlackTree = new RedBlackTree<IkIndexElement, IxResultElement>();

                    foreach (IkIndexElement kIndexElement in k.Value)
                    {
                        secondInnerRedBlackTree.Add(
                            kIndexElement,
                            xResultElementFactory.Create(
                                iIndexElement,
                                jIndexElement,
                                kIndexElement,
                                this.GetElementAt(
                                    iIndexElement,
                                    jIndexElement,
                                    kIndexElement)));
                    }

                    firstInnerRedBlackTree.Add(
                        jIndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    iIndexElement,
                    firstInnerRedBlackTree);
            }

            return xFactory.Create(
                outerRedBlackTree);
        }
    }
}