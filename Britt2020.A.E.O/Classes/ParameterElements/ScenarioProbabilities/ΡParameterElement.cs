namespace Britt2020.A.E.O.Classes.ParameterElements.ScenarioProbabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    internal sealed class ΡParameterElement : IΡParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΡParameterElement(
            IωIndexElement ωIndexElement,
            FhirDecimal value)
        {
            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IωIndexElement ωIndexElement { get; }

        public FhirDecimal Value { get; }
    }
}