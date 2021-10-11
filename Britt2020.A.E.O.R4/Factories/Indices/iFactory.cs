namespace Britt2020.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Indices;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.InterfacesFactories.Indices;

    internal sealed class iFactory : IiFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iFactory()
        {
        }

        public Ii Create(
            ImmutableList<IiIndexElement> value)
        {
            Ii index = null;

            try
            {
                index = new i(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }
    }
}