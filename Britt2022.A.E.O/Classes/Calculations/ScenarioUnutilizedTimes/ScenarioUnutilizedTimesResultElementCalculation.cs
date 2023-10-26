namespace Britt2022.A.E.O.Classes.Calculations.ScenarioUnutilizedTimes
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    
    internal sealed class ScenarioUnutilizedTimesResultElementCalculation : IScenarioUnutilizedTimesResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElementCalculation()
        {
        }

        public IScenarioUnutilizedTimesResultElement Calculate(
            IScenarioUnutilizedTimesResultElementFactory scenarioUnutilizedTimesResultElementFactory,
            IωIndexElement ωIndexElement,
            IScenarioTotalTimes scenarioTotalTimes,
            IScenarioUtilizedTimes scenarioUtilizedTimes)
        {
            return scenarioUnutilizedTimesResultElementFactory.Create(
                ωIndexElement,
                scenarioTotalTimes.GetElementAtAsdecimal(
                    ωIndexElement)
                -
                scenarioUtilizedTimes.GetElementAtAsdecimal(
                    ωIndexElement));
        }
    }
}