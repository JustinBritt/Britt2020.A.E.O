namespace Britt2022.A.E.O.Classes.Parameters.StrategicTargets
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;

    internal sealed class N : IN
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public N(
            ImmutableList<INParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<INParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            int value = this.Value
                .Where(x => x.iIndexElement == iIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();

            return value;
        }
    }
}