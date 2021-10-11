namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Configurations;

    public interface IConfigurationsAbstractFactory
    {
        IWGPMConfigurationFactory CreateWGPMConfigurationFactory();
    }
}