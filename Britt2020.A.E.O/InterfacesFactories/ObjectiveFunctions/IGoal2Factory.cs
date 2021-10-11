namespace Britt2020.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2020.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2020.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IGoal2Factory
    {
        IGoal2 Create(
            IObjectiveFactory objectiveFactory,
            Iijkω ijkω,
            Iw2 w2,
            IΡ Ρ,
            Id2Minus d2Minus);
    }
}