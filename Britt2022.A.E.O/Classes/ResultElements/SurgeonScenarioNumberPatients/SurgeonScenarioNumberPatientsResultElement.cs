namespace Britt2022.A.E.O.Classes.ResultElements.SurgeonScenarioNumberPatients
{
    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElement : ISurgeonScenarioNumberPatientsResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElement(
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