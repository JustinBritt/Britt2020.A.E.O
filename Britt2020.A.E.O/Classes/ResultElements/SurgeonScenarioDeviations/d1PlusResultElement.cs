namespace Britt2020.A.E.O.Classes.ResultElements.SurgeonScenarioDeviations
{
    using log4net;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;

    internal sealed class d1PlusResultElement : Id1PlusResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1PlusResultElement(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public int Value { get; }
    }
}