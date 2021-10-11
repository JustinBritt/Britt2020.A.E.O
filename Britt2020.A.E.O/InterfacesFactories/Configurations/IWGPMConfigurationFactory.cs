namespace Britt2020.A.E.O.InterfacesFactories.Configurations
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Britt2020.A.E.O.Interfaces.Configurations;

    public interface IWGPMConfigurationFactory
    {
        IWGPMConfiguration Create(
            Configuration configuration);
    }
}