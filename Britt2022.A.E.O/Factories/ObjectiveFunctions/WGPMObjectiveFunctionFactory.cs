namespace Britt2022.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ObjectiveFunctions;
    using Britt2022.A.E.O.Interfaces.ObjectiveFunctions;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Britt2022.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class WGPMObjectiveFunctionFactory : IWGPMObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMObjectiveFunctionFactory()
        {
        }

        public IWGPMObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            IGoal1 goal1,
            IGoal2 goal2,
            IGoal3 goal3,
            IGoal4 goal4)
        {
            IWGPMObjectiveFunction instance = null;
            
            try
            {
                instance = new WGPMObjectiveFunction(
                    objectiveFactory,
                    goal1,
                    goal2,
                    goal3,
                    goal4);
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