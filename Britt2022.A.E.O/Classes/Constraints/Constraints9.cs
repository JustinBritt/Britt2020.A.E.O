namespace Britt2022.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints9 : IConstraints9
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9(
            ImmutableList<IConstraints9ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints9ConstraintElement> Value { get; }
    }
}