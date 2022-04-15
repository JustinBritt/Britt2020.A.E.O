namespace Britt2022.A.E.O.Classes.ObjectiveFunctions
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class Goal2 : IGoal2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Goal2(
            IObjectiveFactory objectiveFactory,
            Iijkω ijkω,
            Iw2 w2,
            IΡ Ρ,
            Id2Minus d2Minus)
        {
            OPTANO.Modeling.Optimization.Expression expression = OPTANO.Modeling.Optimization.Expression.Sum(
                ijkω.Value
                .Select(
                    x =>
                    (double)w2.Value.Value.Value
                    *
                    (double)Ρ.GetElementAtAsdecimal(
                        x.ωIndexElement)
                    *
                    d2Minus.Value[x.iIndexElement, x.jIndexElement, x.kIndexElement, x.ωIndexElement]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}