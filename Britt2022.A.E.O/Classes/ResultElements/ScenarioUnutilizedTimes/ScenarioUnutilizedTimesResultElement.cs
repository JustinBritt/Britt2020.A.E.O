namespace Britt2022.A.E.O.Classes.ResultElements.ScenarioUnutilizedTimes
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;

    internal sealed class ScenarioUnutilizedTimesResultElement : IScenarioUnutilizedTimesResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnutilizedTimesResultElement(
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