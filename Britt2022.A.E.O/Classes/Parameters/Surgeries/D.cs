namespace Britt2022.A.E.O.Classes.Parameters.Surgeries
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;

    internal sealed class D : ID
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public D(
            ImmutableList<IDParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IDParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            IωIndexElement ωIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.eIndexElement == eIndexElement && x.ωIndexElement == ωIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}