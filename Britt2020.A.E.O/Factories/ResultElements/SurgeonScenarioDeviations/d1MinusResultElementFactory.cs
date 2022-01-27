namespace Britt2020.A.E.O.Factories.ResultElements.SurgeonScenarioDeviations
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;

    internal sealed  class d1MinusResultElementFactory : Id1MinusResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1MinusResultElementFactory()
        {
        }

        public Id1MinusResultElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            int value)
        {
            Id1MinusResultElement resultElement = null;

            try
            {
                resultElement = new d1MinusResultElement(
                    iIndexElement,
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