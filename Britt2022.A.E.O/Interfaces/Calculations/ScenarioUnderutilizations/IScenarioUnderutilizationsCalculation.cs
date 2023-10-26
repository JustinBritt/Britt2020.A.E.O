namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations
{
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsCalculation
    {
        IScenarioUnderutilizations Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IScenarioUnderutilizationsFactory scenarioUnderutilizationsFactory,
            IScenarioUnderutilizationsResultElementCalculation scenarioUnderutilizationsResultElementCalculation,
            Iω ω,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes);
    }
}