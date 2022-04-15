namespace Britt2022.A.E.O.Classes.ParameterElements.PreferencesOfSurgeons
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;

    internal sealed class ΩParameterElement : IΩParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΩParameterElement(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement,
            FhirBoolean value)
        {
            this.iIndexElement = iIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public FhirBoolean Value { get; }
    }
}