namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.SolverConfigurations;

    public interface ISolverConfigurationsAbstractFactory
    {
        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}