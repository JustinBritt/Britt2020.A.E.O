namespace Britt2022.A.E.O.Classes.ParameterElements.LengthsOfStay
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    internal sealed class ΦParameterElement : IΦParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦParameterElement(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement,
            FhirDecimal value)
        {
            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public FhirDecimal Value { get; }
    }
}