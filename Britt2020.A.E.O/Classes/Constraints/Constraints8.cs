namespace Britt2020.A.E.O.Classes.Constraints
{
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.Constraints;

    internal sealed class Constraints8 : IConstraints8
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8(
            ImmutableList<IConstraints8ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints8ConstraintElement> Value { get; }
    }
}