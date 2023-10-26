namespace Britt2022.A.E.O.Factories.Results.ScenarioTotalTimes
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesFactory : IScenarioTotalTimesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesFactory()
        {
        }

        public IScenarioTotalTimes Create(
            ImmutableList<IScenarioTotalTimesResultElement> value)
        {
            IScenarioTotalTimes instance = null;

            try
            {
                instance = new ScenarioTotalTimes(
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