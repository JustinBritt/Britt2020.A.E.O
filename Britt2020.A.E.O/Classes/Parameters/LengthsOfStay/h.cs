namespace Britt2020.A.E.O.Classes.Parameters.LengthsOfStay
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2020.A.E.O.Interfaces.Parameters.LengthsOfStay;

    internal sealed class h : Ih
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public h(
            ImmutableList<IhParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IhParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}