namespace Britt2022.A.E.O.Classes.Parameters.PreferencesOfSurgeons
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;

    internal sealed class Ω : IΩ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ω(
            ImmutableList<IΩParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΩParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.kIndexElement == kIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}