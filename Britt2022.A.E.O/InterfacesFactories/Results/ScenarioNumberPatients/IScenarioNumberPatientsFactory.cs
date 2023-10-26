namespace Britt2022.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsFactory
    {
        IScenarioNumberPatients Create(
            ImmutableList<IScenarioNumberPatientsResultElement> value);
    }
}