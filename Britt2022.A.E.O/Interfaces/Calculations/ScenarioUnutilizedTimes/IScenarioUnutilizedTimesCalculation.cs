namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes
{
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;

    public interface IScenarioUnutilizedTimesCalculation
    {
        IScenarioUnutilizedTimes Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IScenarioUnutilizedTimesFactory scenarioUnutilizedTimesFactory,
            IScenarioUnutilizedTimesResultElementCalculation scenarioUnutilizedTimesResultElementCalculation,
            Iω ω,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes);
    }
}