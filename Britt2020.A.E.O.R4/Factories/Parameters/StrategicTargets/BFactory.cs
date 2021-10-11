namespace Britt2020.A.E.O.Factories.Parameters.StrategicTargets
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.StrategicTargets;

    internal sealed class BFactory : IBFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BFactory()
        {
        }

        public IB Create(
            ImmutableList<IBParameterElement> value)
        {
            IB parameter = null;

            try
            {
                parameter = new B(
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