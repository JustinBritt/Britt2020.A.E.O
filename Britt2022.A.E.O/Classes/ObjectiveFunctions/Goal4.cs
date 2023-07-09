namespace Britt2022.A.E.O.Classes.ObjectiveFunctions
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class Goal4 : IGoal4
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Goal4(
            IObjectiveFactory objectiveFactory,
            Iω ω,
            Iw4 w4,
            IΡ Ρ,
            IIMax IMax,
            IIMin IMin)
        {
            Expression expression = Expression.Sum(
                ω.Value.Values
                .Select(
                    x =>
                    (double)w4.Value.Value.Value
                    *
                    (double)Ρ.GetElementAtAsdecimal(
                        x)
                    *
                    (IMax.Value[x]
                    -
                    IMin.Value[x])));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}