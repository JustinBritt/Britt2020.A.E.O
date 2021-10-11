namespace Britt2020.A.E.O.Classes.Configurations
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Britt2020.A.E.O.Interfaces.Configurations;

    internal sealed class WGPMConfiguration : IWGPMConfiguration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMConfiguration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}