namespace Britt2020.A.E.O.Classes.ParameterElements.StrategicTargets
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets;

    internal sealed class LParameterElement : ILParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LParameterElement(
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