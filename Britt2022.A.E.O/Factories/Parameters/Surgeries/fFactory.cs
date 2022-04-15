namespace Britt2022.A.E.O.Factories.Parameters.Surgeries
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.Surgeries;

    internal sealed class fFactory : IfFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public fFactory()
        {
        }

        public If Create(
            ImmutableList<IfParameterElement> value)
        {
            If parameter = null;

            try
            {
                parameter = new f(
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