namespace Britt2022.A.E.O.Classes.ParameterElements.Surgeries
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    internal sealed class OParameterElement : IOParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OParameterElement(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            INullableValue<decimal> value)
        {
            this.iIndexElement = iIndexElement;

            this.eIndexElement = eIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IeIndexElement eIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}