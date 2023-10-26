namespace Britt2022.A.E.O.Factories.Calculations.ScenarioTotalTimes
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesCalculationFactory : IScenarioTotalTimesCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesCalculationFactory()
        {
        }

        public IScenarioTotalTimesCalculation Create()
        {
            IScenarioTotalTimesCalculation instance = null;

            try
            {
                instance = new ScenarioTotalTimesCalculation();
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