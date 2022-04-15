namespace Britt2022.A.E.O.Classes.Parameters.ScenarioProbabilities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    internal sealed class Ρ : IΡ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ρ(
            ImmutableList<IΡParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΡParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IωIndexElement ωIndexElement)
        {
            return this.Value
                .Where(x => x.ωIndexElement == ωIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}