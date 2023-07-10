namespace Britt2022.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;

    public interface IIMin
    {
        VariableCollection<IωIndexElement> Value { get; }

        decimal GetElementAt(
            IωIndexElement ωIndexElement);

        Interfaces.Results.ScenarioRecoveryWardCensuses.IIMin GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IIMinResultElementFactory IMinResultElementFactory,
            IIMinFactory IMinFactory,
            Iω ω);
    }
}