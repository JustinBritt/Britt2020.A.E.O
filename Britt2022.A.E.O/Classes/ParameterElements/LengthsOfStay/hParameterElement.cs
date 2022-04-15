namespace Britt2022.A.E.O.Classes.ParameterElements.LengthsOfStay
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    internal sealed class hParameterElement : IhParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public hParameterElement(
            IiIndexElement iIndexElement,
            PositiveInt value)
        {
            this.iIndexElement = iIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public PositiveInt Value { get; }
    }
}