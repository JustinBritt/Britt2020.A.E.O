namespace Britt2022.A.E.O.Factories.ResultElements.ScenarioUnutilizedTimes
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesResultElementFactory : IScenarioUnutilizedTimesResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElementFactory()
        {
        }

        public IScenarioUnutilizedTimesResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value)
        {
            IScenarioUnutilizedTimesResultElement resultElement = null;

            try
            {
                resultElement = new ScenarioUnutilizedTimesResultElement(
                    ωIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}