namespace Britt2022.A.E.O.Factories.ResultElements.DayScenarioRecoveryWardCensuses
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;

    internal sealed class IResultElementFactory : IIResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IResultElementFactory()
        {
        }

        public IIResultElement Create(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            decimal value)
        {
            IIResultElement resultElement = null;

            try
            {
                resultElement = new IResultElement(
                    kIndexElement,
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