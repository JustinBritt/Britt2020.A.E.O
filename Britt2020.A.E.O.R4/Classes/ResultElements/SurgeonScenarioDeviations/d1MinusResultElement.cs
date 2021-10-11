namespace Britt2020.A.E.O.Classes.ResultElements.SurgeonScenarioDeviations
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;

    internal sealed class d1MinusResultElement : Id1MinusResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1MinusResultElement(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            decimal value)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public decimal Value { get; }
    }
}