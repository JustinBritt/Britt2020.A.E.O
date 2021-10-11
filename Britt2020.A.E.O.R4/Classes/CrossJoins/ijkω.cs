namespace Britt2020.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;

    internal sealed class ijkω : Iijkω
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijkω(
            ImmutableList<IijkωCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IijkωCrossJoinElement> Value { get; }
    }
}