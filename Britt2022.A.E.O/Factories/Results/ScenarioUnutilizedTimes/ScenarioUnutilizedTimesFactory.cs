namespace Britt2022.A.E.O.Factories.Results.ScenarioUnutilizedTimes
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesFactory : IScenarioUnutilizedTimesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesFactory()
        {
        }

        public IScenarioUnutilizedTimes Create(
            ImmutableList<IScenarioUnutilizedTimesResultElement> value)
        {
            IScenarioUnutilizedTimes instance = null;

            try
            {
                instance = new ScenarioUnutilizedTimes(
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