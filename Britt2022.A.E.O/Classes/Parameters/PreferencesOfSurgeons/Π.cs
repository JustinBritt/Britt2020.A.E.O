namespace Britt2022.A.E.O.Classes.Parameters.PreferencesOfSurgeons
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;

    internal sealed class Π : IΠ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Π(
            ImmutableList<IΠParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΠParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement)
        {
            return this.Value
                .Where(x => x.iIndexElement == iIndexElement && x.jIndexElement == jIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}