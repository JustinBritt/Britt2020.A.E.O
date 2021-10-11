namespace Britt2020.A.E.O.Factories.Parameters.LengthsOfStay
{
    using System;
    using System.Collections.Immutable;
  
    using log4net;

    using Britt2020.A.E.O.Classes.Parameters.LengthsOfStay;
    using Britt2020.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2020.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.LengthsOfStay;

    internal sealed class pFactory : IpFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pFactory()
        {
        }

        public Ip Create(
            ImmutableList<IpParameterElement> value)
        {
            Ip parameter = null;

            try
            {
                parameter = new p(
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