namespace Britt2022.A.E.O.Classes.ResultElements.ScenarioRecoveryWardCensuses
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;

    internal sealed class IMaxResultElement : IIMaxResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMaxResultElement(
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
