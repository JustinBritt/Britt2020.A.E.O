namespace Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2MinusFactory
    {
        Id2Minus Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>> value);
    }
}