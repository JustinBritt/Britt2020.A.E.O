namespace Britt2022.A.E.O.Classes.ResultElements.SurgeonOperatingRoomDayScenarioDeviations
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2MinusResultElement : Id2MinusResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2MinusResultElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            decimal value)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public decimal Value { get; }   
    }
}