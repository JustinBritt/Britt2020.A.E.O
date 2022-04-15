namespace Britt2022.A.E.O.Classes.ObjectiveFunctions
{
    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class WGPMObjectiveFunction : IWGPMObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMObjectiveFunction(
            IObjectiveFactory objectiveFactory,
            IGoal1 goal1,
            IGoal2 goal2,
            IGoal3 goal3,
            IGoal4 goal4)
        {
            Expression expression = 
                goal1.Value.Expression
                +
                goal2.Value.Expression
                +
                goal3.Value.Expression
                +
                goal4.Value.Expression;

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}