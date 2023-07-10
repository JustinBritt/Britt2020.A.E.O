namespace Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;

    public interface Id1PlusFactory
    {
        Id1Plus Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>> value);
    }
}