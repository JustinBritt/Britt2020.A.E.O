namespace Britt2022.A.E.O.Classes.ResultElements.DayScenarioRecoveryWardCensuses
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;

    internal sealed class IResultElement : IIResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IResultElement(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            decimal value)
        {
            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IkIndexElement kIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public decimal Value { get; }
    }
}