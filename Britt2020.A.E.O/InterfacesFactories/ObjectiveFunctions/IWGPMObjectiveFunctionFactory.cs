namespace Britt2020.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using Britt2020.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IWGPMObjectiveFunctionFactory
    {
        IWGPMObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            IGoal1 goal1,
            IGoal2 goal2,
            IGoal3 goal3,
            IGoal4 goal4);
    }
}