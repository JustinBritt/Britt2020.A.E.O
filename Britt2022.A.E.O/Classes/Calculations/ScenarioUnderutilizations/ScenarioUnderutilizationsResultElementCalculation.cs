namespace Britt2022.A.E.O.Classes.Calculations.ScenarioUnderutilizations
{
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsResultElementCalculation : IScenarioUnderutilizationsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsResultElementCalculation()
        {
        }

        public IScenarioUnderutilizationsResultElement Calculate(
            IScenarioUnderutilizationsResultElementFactory scenarioUnderutilizationsResultElementFactory,
            IωIndexElement ωIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUnutilizedTimes scenarioUnutilizedTimes)
        {
            return scenarioUnderutilizationsResultElementFactory.Create(
                ωIndexElement,
                scenarioUnutilizedTimes.Value.Where(w => w.ωIndexElement == ωIndexElement).Select(w => w.Value).SingleOrDefault()
                /
                scenarioTotalTimes.Value.Where(w => w.ωIndexElement == ωIndexElement).Select(w => w.Value).SingleOrDefault());
        }
    }
}