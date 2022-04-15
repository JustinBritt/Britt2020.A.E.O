namespace Britt2022.A.E.O.Factories.Configurations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Britt2022.A.E.O.Classes.Configurations;
    using Britt2022.A.E.O.Interfaces.Configurations;
    using Britt2022.A.E.O.InterfacesFactories.Configurations;

    internal sealed class WGPMConfigurationFactory : IWGPMConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMConfigurationFactory()
        {
        }

        public IWGPMConfiguration Create(
            Configuration configuration)
        {
            IWGPMConfiguration WGPMConfiguration = null;

            try
            {
                WGPMConfiguration = new WGPMConfiguration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return WGPMConfiguration;
        }
    }
}