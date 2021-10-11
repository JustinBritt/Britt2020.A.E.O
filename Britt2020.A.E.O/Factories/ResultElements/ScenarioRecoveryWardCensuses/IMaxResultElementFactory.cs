namespace Britt2020.A.E.O.Factories.ResultElements.ScenarioRecoveryWardCensuses
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;

    internal sealed class IMaxResultElementFactory : IIMaxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMaxResultElementFactory()
        {
        }

        public IIMaxResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value)
        {
            IIMaxResultElement resultElement = null;

            try
            {
                resultElement = new IMaxResultElement(
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