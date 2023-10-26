namespace Britt2022.A.E.O.Classes.ResultElements.ScenarioUnderutilizations
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsResultElement : IScenarioUnderutilizationsResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsResultElement(
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