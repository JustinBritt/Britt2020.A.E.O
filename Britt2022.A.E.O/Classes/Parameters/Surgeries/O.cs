namespace Britt2022.A.E.O.Classes.Parameters.Surgeries
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;

    internal sealed class O : IO
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public O(
            ImmutableList<IOParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IOParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.eIndexElement == eIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}