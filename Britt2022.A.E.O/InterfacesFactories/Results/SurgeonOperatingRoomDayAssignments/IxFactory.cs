namespace Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;

    public interface IxFactory
    {
        Ix Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>> value);
    }
}