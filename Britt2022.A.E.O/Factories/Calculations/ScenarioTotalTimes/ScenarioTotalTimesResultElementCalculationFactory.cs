namespace Britt2022.A.E.O.Factories.Calculations.ScenarioTotalTimes
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesResultElementCalculationFactory : IScenarioTotalTimesResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesResultElementCalculationFactory()
        {
        }

        public IScenarioTotalTimesResultElementCalculation Create()
        {
            IScenarioTotalTimesResultElementCalculation instance = null;

            try
            {
                instance = new ScenarioTotalTimesResultElementCalculation();
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