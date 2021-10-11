namespace Britt2020.A.E.O.Classes.Parameters.Surgeries
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;

    internal sealed class n : In
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public n(
            ImmutableList<InParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<InParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            int value = this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.ωIndexElement == ωIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();

            return value;
        }
    }
}