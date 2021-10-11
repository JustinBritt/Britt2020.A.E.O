namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.ObjectiveFunctions;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IGoal1Factory CreateGoal1Factory();

        IGoal2Factory CreateGoal2Factory();

        IGoal3Factory CreateGoal3Factory();

        IGoal4Factory CreateGoal4Factory();

        IWGPMObjectiveFunctionFactory CreateWGPMObjectiveFunctionFactory();
    }
}