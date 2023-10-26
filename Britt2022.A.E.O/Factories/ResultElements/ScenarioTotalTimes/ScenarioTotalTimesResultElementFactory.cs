namespace Britt2022.A.E.O.Factories.ResultElements.ScenarioTotalTimes
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesResultElementFactory : IScenarioTotalTimesResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesResultElementFactory()
        {
        }

        public IScenarioTotalTimesResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value)
        {
            IScenarioTotalTimesResultElement instance = null;

            try
            {
                instance = new ScenarioTotalTimesResultElement(
                    ωIndexElement,
                    value);
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