namespace Britt2020.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;

    internal sealed class ie : Iie
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ie(
            ImmutableList<IieCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IieCrossJoinElement> Value { get; }
    }
}