namespace Britt2022.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IGoal3Factory
    {
        IGoal3 Create(
            IObjectiveFactory objectiveFactory,
            Iω ω,
            Iw3 w3,
            IΡ Ρ,
            IIMax IMax);
    }
}