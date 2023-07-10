namespace Britt2022.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    public interface II
    {
        VariableCollection<IkIndexElement, IωIndexElement> Value { get; }

        decimal GetElementAt(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement);

        Interfaces.Results.DayScenarioRecoveryWardCensuses.II GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IIResultElementFactory IResultElementFactory,
            IIFactory IFactory,
            Ik k,
            Iω ω);
    }
}