namespace Britt2020.A.E.O.Factories.Results.ScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Results.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;

    internal sealed class IMinFactory : IIMinFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMinFactory()
        {
        }

        public IIMin Create(
            ImmutableList<IIMinResultElement> value)
        {
            IIMin result = null;

            try
            {
                result = new IMin(
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