namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsResultElementCalculation
    {
        IScenarioUnderutilizationsResultElement Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IωIndexElement ωIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes);
    }
}