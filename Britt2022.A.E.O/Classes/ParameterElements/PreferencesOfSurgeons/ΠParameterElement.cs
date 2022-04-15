namespace Britt2022.A.E.O.Classes.ParameterElements.PreferencesOfSurgeons
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;

    internal sealed class ΠParameterElement : IΠParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΠParameterElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            FhirBoolean value)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IjIndexElement jIndexElement { get; }

        public FhirBoolean Value { get; }
    }
}