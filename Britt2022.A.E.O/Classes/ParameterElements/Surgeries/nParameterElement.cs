namespace Britt2022.A.E.O.Classes.ParameterElements.Surgeries
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    internal sealed class nParameterElement : InParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public nParameterElement(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            INullableValue<int> value)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public INullableValue<int> Value { get; }
    }
}