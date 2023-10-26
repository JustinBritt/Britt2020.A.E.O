namespace Britt2022.A.E.O.Classes.Calculations.ScenarioUnutilizedTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesCalculation : IScenarioUnutilizedTimesCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesCalculation()
        {
        }

        public IScenarioUnutilizedTimes Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IScenarioUnutilizedTimesFactory scenarioUnutilizedTimesFactory,
            IScenarioUnutilizedTimesResultElementCalculation scenarioUnutilizedTimesResultElementCalculation,
            Iω ω,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes)
        {
            return scenarioUnutilizedTimesFactory.Create(
                ω.Value.Values
                .Select(w => scenarioUnutilizedTimesResultElementCalculation.Calculate(
                    scenarioUnutilizedTimesResultElementFactory,
                    w,
                    scenarioTotalTimes,
                    scenarioUtilizedTimes))
                .ToImmutableList());
        }
    }
}