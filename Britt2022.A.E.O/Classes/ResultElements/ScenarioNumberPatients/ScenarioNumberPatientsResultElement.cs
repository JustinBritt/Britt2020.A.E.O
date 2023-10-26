namespace Britt2022.A.E.O.Classes.ResultElements.ScenarioNumberPatients
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElement : IScenarioNumberPatientsResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElement(
            IωIndexElement ωIndexElement,
            int value)
        {
            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IωIndexElement ωIndexElement { get; }

        public int Value { get; }
    }
}