namespace Britt2022.A.E.O.Factories.ResultElements.SurgeonScenarioDeviations
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;

    internal sealed class d1PlusResultElementFactory : Id1PlusResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1PlusResultElementFactory()
        {
        }

        public Id1PlusResultElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            int value)
        {
            Id1PlusResultElement instance = null;

            try
            {
                instance = new d1PlusResultElement(
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

            return instance;
        }
    }
}