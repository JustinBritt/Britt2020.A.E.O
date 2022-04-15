namespace Britt2022.A.E.O.Classes.Parameters.StrategicTargets
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            ImmutableList<IBParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IBParameterElement> Value { get; }

        public int GetElementAtAsint(
            IrIndexElement rIndexElement)
        {
            return this.Value
                .Where(x => x.rIndexElement == rIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}