namespace Britt2022.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;

    public interface IIFactory
    {
        II Create(
            RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>> value);
    }
}