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

    internal sealed class Goal1 : IGoal1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Goal1(
            IObjectiveFactory objectiveFactory,
            Iiω iω,
            Iw1 w1,
            IΡ Ρ,
            Id1Minus d1Minus)
        {
            Expression expression = Expression.Sum(
                iω.Value
                .Select(
                    x => 
                    (double)w1.Value.Value.Value
                    *
                    (double)Ρ.GetElementAtAsdecimal(
                        x.ωIndexElement)
                    *
                    d1Minus.Value[x.iIndexElement, x.ωIndexElement]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}