namespace Britt2022.A.E.O.InterfacesFactories.Configurations
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Britt2022.A.E.O.Interfaces.Configurations;

    public interface IWGPMConfigurationFactory
    {
        IWGPMConfiguration Create(
            Configuration configuration);
    }
}