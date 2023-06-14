namespace Britt2022.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Britt2022.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class Goal1Factory : IGoal1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Goal1Factory()
        {
        }

        public IGoal1 Create(
            IObjectiveFactory objectiveFactory,
            Iiω iω,
            Iw1 w1,
            IΡ Ρ,
            Id1Minus d1Minus)
        {
            IGoal1 instance = null;

            try
            {
                instance = new Goal1(
                    objectiveFactory,
                    iω,
                    w1,
                    Ρ,
                    d1Minus);
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