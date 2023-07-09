namespace Britt2022.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Britt2022.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class Goal3Factory : IGoal3Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Goal3Factory()
        {
        }

        public IGoal3 Create(
            IObjectiveFactory objectiveFactory,
            Iω ω,
            Iw3 w3,
            IΡ Ρ,
            IIMax IMax)
        {
            IGoal3 instance = null;

            try
            {
                instance = new Goal3(
                    objectiveFactory,
                    ω,
                    w3,
                    Ρ,
                    IMax);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}