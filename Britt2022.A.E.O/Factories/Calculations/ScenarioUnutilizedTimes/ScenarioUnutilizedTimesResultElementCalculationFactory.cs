namespace Britt2022.A.E.O.Factories.Calculations.ScenarioUnutilizedTimes
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Calculations.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesResultElementCalculationFactory : IScenarioUnutilizedTimesResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElementCalculationFactory()
        {
        }

        public IScenarioUnutilizedTimesResultElementCalculation Create()
        {
            IScenarioUnutilizedTimesResultElementCalculation instance = null;

            try
            {
                instance = new ScenarioUnutilizedTimesResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}