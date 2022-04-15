namespace Britt2022.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Factories.Configurations;
    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.InterfacesFactories.Configurations;

    internal sealed class ConfigurationsAbstractFactory : IConfigurationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConfigurationsAbstractFactory()
        {
        }

        public IWGPMConfigurationFactory CreateWGPMConfigurationFactory()
        {
            IWGPMConfigurationFactory factory = null;

            try
            {
                factory = new WGPMConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}