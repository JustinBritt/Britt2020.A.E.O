namespace Britt2022.A.E.O.Classes.ResultElements.ScenarioRecoveryWardCensuses
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;

    internal sealed class IMinResultElement : IIMinResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMinResultElement(
            IωIndexElement ωIndexElement,
            decimal value)
        {
            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IωIndexElement ωIndexElement { get; }

        public decimal Value { get; }
    }
}