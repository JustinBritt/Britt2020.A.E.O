namespace Britt2020.A.E.O.Classes.ParameterElements.StrategicTargets
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets;

    internal sealed class BParameterElement : IBParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BParameterElement(
            IrIndexElement rIndexElement,
            PositiveInt value)
        {
            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public IrIndexElement rIndexElement { get; }

        public PositiveInt Value { get; }
    }
}