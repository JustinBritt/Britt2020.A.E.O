namespace Britt2020.A.E.O.InterfacesFactories.SolverConfigurations
{
    using Britt2020.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration);
    }
}