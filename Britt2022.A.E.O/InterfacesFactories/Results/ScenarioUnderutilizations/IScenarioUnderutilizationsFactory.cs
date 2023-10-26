namespace Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsFactory
    {
        IScenarioUnderutilizations Create(
            ImmutableList<IScenarioUnderutilizationsResultElement> value);
    }
}