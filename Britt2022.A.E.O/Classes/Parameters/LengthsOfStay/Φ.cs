namespace Britt2022.A.E.O.Classes.Parameters.LengthsOfStay
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;

    internal sealed class Φ : IΦ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Φ(
            ImmutableList<IΦParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΦParameterElement> Value { get; }

        public double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.lIndexElement == lIndexElement && x.ωIndexElement == ωIndexElement)
                .Select(x => (double)x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}