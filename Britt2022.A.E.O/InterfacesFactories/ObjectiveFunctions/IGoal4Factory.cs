namespace Britt2022.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IGoal4Factory
    {
        IGoal4 Create(
            IObjectiveFactory objectiveFactory,
            Ik k,
            Iω ω,
            Iw4 w4,
            IΡ Ρ,
            IIMax IMax,
            IIMin IMin);
    }
}