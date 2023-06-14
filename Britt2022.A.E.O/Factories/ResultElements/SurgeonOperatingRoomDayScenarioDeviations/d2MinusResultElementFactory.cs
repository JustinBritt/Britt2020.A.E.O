namespace Britt2022.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2MinusResultElementFactory : Id2MinusResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2MinusResultElementFactory()
        {
        }

        public Id2MinusResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            decimal value)
        {
            Id2MinusResultElement instance = null;

            try
            {
                instance = new d2MinusResultElement(
                    iIndexElement,
                    jIndexElement,
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

            return instance;
        }
    }
}