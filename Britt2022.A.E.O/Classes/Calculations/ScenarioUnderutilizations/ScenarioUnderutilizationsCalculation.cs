namespace Britt2022.A.E.O.Classes.Calculations.ScenarioUnderutilizations
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsCalculation : IScenarioUnderutilizationsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsCalculation()
        {
        }

        public IScenarioUnderutilizations Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IScenarioUnderutilizationsFactory scenarioUnderutilizationsFactory,
            IScenarioUnderutilizationsResultElementCalculation scenarioUnderutilizationsResultElementCalculation,
            Iω ω,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes)
        {
            return scenarioUnderutilizationsFactory.Create(
                ω.Value.Values
                .Select(w => scenarioUnderutilizationsResultElementCalculation.Calculate(
                    scenarioUnderutilizationsResultElementFactory,
                    w,
                    scenarioTotalTimes,
                    scenarioUnutilizedTimes))
                .ToImmutableList());
        }
    }
}