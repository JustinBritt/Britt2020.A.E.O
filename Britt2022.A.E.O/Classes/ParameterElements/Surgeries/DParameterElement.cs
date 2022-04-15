namespace Britt2022.A.E.O.Classes.ParameterElements.Surgeries
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    internal sealed class DParameterElement : IDParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DParameterElement(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            IωIndexElement ωIndexElement,
            Duration value)
        {
            this.iIndexElement = iIndexElement;

            this.eIndexElement = eIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IeIndexElement eIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public Duration Value { get; }
    }
}