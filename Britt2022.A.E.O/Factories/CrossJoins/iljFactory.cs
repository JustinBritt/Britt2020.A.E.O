namespace Britt2022.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoins;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class iljFactory : IiljFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iljFactory()
        {
        }

        public Iilj Create(
            ImmutableList<IiljCrossJoinElement> value)
        {
            Iilj crossJoin = null;

            try
            {
                crossJoin = new ilj(
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