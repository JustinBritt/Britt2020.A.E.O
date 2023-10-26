namespace Britt2022.A.E.O.Factories.ResultElements.ScenarioUtilizedTimes
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesResultElementFactory : IScenarioUtilizedTimesResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesResultElementFactory()
        {
        }

        public IScenarioUtilizedTimesResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value)
        {
            IScenarioUtilizedTimesResultElement instance = null;

            try
            {
                instance = new ScenarioUtilizedTimesResultElement(
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