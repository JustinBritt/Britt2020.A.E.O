namespace Britt2020.A.E.O.Factories.Results.DayScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Results.DayScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;

    internal sealed class IFactory : IIFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IFactory()
        {
        }

        public II Create(
            ImmutableList<IIResultElement> value)
        {
            II result = null;

            try
            {
                result = new I(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}