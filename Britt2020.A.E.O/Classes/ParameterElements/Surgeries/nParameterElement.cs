namespace Britt2020.A.E.O.Classes.ParameterElements.Surgeries
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries;

    internal sealed class nParameterElement : InParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public nParameterElement(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            PositiveInt value)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public PositiveInt Value { get; }
    }
}