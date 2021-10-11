namespace Britt2020.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.CrossJoins;
    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class kωFactory : IkωFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kωFactory()
        {
        }

        public Ikω Create(
            ImmutableList<IkωCrossJoinElement> value)
        {
            Ikω crossJoin = null;

            try
            {
                crossJoin = new kω(
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