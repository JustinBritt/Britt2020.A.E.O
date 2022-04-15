namespace Britt2022.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IGoal1Factory
    {
        IGoal1 Create(
            IObjectiveFactory objectiveFactory,
            Iiω iω,
            Iw1 w1,
            IΡ Ρ,
            Id1Minus d1Minus);
    }
}