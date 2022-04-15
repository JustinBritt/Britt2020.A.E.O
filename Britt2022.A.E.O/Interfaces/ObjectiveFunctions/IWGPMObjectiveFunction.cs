namespace Britt2022.A.E.O.Interfaces.ObjectiveFunctions
{
    using OPTANO.Modeling.Optimization;

    public interface IWGPMObjectiveFunction
    {
        Objective Value { get; }
    }
}