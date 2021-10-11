namespace Britt2020.A.E.O.Factories.Parameters.PreferencesOfSurgeons
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Parameters.PreferencesOfSurgeons;
    using Britt2020.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2020.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons;

    internal sealed class ΩFactory : IΩFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΩFactory()
        {
        }

        public IΩ Create(
            ImmutableList<IΩParameterElement> value)
        {
            IΩ parameter = null;

            try
            {
                parameter = new Ω(
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