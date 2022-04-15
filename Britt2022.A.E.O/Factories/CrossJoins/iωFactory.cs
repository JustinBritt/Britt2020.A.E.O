namespace Britt2022.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoins;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class iωFactory : IiωFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iωFactory()
        {
        }

        public Iiω Create(
            ImmutableList<IiωCrossJoinElement> value)
        {
            Iiω crossJoin = null;

            try
            {
                crossJoin = new iω(
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