namespace Britt2022.A.E.O.Classes.Parameters.Surgeries
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;

    internal sealed class A : IA
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public A(
            ImmutableList<IAParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IAParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.ωIndexElement == ωIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }

        public double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.ωIndexElement == ωIndexElement)
                .Select(x => (double)x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}