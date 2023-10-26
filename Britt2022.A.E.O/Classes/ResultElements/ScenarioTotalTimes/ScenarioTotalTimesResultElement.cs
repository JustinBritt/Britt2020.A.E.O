namespace Britt2022.A.E.O.Classes.ResultElements.ScenarioTotalTimes
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesResultElement : IScenarioTotalTimesResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesResultElement(
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