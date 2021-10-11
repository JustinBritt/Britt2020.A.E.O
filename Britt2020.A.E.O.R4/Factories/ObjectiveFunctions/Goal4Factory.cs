namespace Britt2020.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.ObjectiveFunctions;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2020.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2020.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Britt2020.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class Goal4Factory : IGoal4Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Goal4Factory()
        {
        }

        public IGoal4 Create(
            IObjectiveFactory objectiveFactory,
            Ik k,
            Iω ω,
            Iw4 w4,
            IΡ Ρ,
            IIMax IMax,
            IIMin IMin)
        {
            IGoal4 objectiveFunction = null;

            try
            {
                objectiveFunction = new Goal4(
                    objectiveFactory,
                    k,
                    ω,
                    w4,
                    Ρ,
                    IMax,
                    IMin);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}