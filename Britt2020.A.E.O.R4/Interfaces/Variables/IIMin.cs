namespace Britt2020.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;

    public interface IIMin
    {
        VariableCollection<IωIndexElement> Value { get; }

        decimal GetElementAt(
            IωIndexElement ωIndexElement);

        Interfaces.Results.ScenarioRecoveryWardCensuses.IIMin GetElementsAt(
            IIMinResultElementFactory IMinResultElementFactory,
            IIMinFactory IMinFactory,
            Iω ω);
    }
}