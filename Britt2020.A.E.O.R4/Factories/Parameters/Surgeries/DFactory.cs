namespace Britt2020.A.E.O.Factories.Parameters.Surgeries
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Parameters.Surgeries;
    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.Surgeries;

    internal sealed class DFactory : IDFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DFactory()
        {
        }

        public ID Create(
            ImmutableList<IDParameterElement> value)
        {
            ID parameter = null;

            try
            {
                parameter = new D(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}