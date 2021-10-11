namespace Britt2020.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.CrossJoins;
    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class ijkωFactory : IijkωFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijkωFactory()
        {
        }

        public Iijkω Create(
            ImmutableList<IijkωCrossJoinElement> value)
        {
            ijkω crossJoin = null;

            try
            {
                crossJoin = new ijkω(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}