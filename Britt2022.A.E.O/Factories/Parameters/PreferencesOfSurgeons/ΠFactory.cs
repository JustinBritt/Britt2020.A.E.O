namespace Britt2022.A.E.O.Factories.Parameters.PreferencesOfSurgeons
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons;

    internal sealed class ΠFactory : IΠFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΠFactory()
        {
        }

        public IΠ Create(
            ImmutableList<IΠParameterElement> value)
        {
            IΠ parameter = null;

            try
            {
                parameter = new Π(
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