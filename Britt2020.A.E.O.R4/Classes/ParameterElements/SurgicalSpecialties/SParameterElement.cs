namespace Britt2020.A.E.O.Classes.ParameterElements.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    internal sealed class SParameterElement : ISParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SParameterElement(
            IrIndexElement rIndexElement,
            ImmutableList<IiIndexElement> value)
        {
            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public IrIndexElement rIndexElement { get; }

        public ImmutableList<IiIndexElement> Value { get; }
    }
}